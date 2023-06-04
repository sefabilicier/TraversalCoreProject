using EntityLayer.Concretes;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace TraversalCoreProject.Areas.Member.Controllers
{
    [Area("Member")]
    public class DashbordController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public DashbordController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.userImage = values.ImageUrl;    
            ViewBag.userName = values.Name + " " + values.Surname;
            return View();
        }

        public async Task<IActionResult> MemberDashboard()
        {
            return View();
        }
    }
}
