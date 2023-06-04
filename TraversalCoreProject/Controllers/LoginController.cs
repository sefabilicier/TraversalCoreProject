using EntityLayer.Concretes;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TraversalCoreProject.Models;

namespace TraversalCoreProject.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {

        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;

        public LoginController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }



        [HttpGet]
        public IActionResult SignUp()
        {
            return View();
        }




        [HttpPost]
        public async Task<IActionResult> SignUp(UserRegisterViewModel u)
        {

            AppUser appUser = new AppUser()
            {
                Name = u.Name,
                Surname = u.Surname,
                Email = u.Mail,
                UserName = u.UserName,
            };

            if (u.Password == u.ConfirmPassword )
            {
                var result = await _userManager.CreateAsync(appUser, u.Password);

                if (result.Succeeded)
                {
                    return RedirectToAction("SignIn");
                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }
            }

            return View(u);
        }

        [HttpGet]
        public IActionResult SignIn()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SignIn(UserSignInViewModel userSignIn)
        {
            var result = await _signInManager.PasswordSignInAsync(userSignIn.UserName, userSignIn.Password,false,true);
            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Profile", new {area = "Member"}); //sign in olduğunda direkt profil sayfasına yonlendirecek beni fakat bu area da yani başka bir pencerede
            }
            else
            {
                return RedirectToAction("SignIn", "Login");
            }

            return View(userSignIn);
        }
    }
}
