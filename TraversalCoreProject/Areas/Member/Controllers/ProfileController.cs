using EntityLayer.Concretes;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Threading.Tasks;
using TraversalCoreProject.Areas.Member.Models;

namespace TraversalCoreProject.Areas.Member.Controllers
{
    [Area("Member")]
    [Route("Member/[controller]/[action]")]
    public class ProfileController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public ProfileController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet] //sayfa yüklendiğinde çalışacak
        public async Task<IActionResult> Index()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);

            UserEditViewModel userEditViewModel = new UserEditViewModel();

            userEditViewModel.Name = values.Name;
            userEditViewModel.surname = values.Surname;
            userEditViewModel.phoneNumber = values.PhoneNumber;
            userEditViewModel.mail = values.Email;
            //şifre kısmı yazılmıyor zaten
            return View(userEditViewModel);
        }


        [HttpPost]
        public async Task<IActionResult> Index(UserEditViewModel useredit)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);

            if (useredit.imageurl != null)
            {
                var resource = Directory.GetCurrentDirectory();
                var extension = Path.GetExtension(useredit.image.FileName);
                var imagename = Guid.NewGuid() + extension; 
                var savelocation = resource + "/wwwroot/userimages/" + imagename;
                var stream = new FileStream(savelocation, FileMode.Create);
                await useredit.image.CopyToAsync(stream);
                user.ImageUrl = imagename;
            }

            user.Name = useredit.Name;
            user.Surname = useredit.surname;
            user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, useredit.password);
            var result = await _userManager.UpdateAsync(user);
            if (result.Succeeded)
            {
                return RedirectToAction("SignIn", "Login");
            }      

            return View();

        }

    }
}
