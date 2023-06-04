using BusinessLayer.Concretes;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.ViewComponents.Default
{
    public class _Testimonials : ViewComponent
    {
        TestimonalManager testimonalManager = new TestimonalManager(new EfTestimonialDal());


        public IViewComponentResult Invoke()
        {
            var values = testimonalManager.TGetList();
            return View(values);
        }
    }
}
