using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.ViewComponents.Admin.AdminDashboard
{
    public class _DashboardBanner : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
