using BusinessLayer.Concretes;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concretes;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.Controllers
{
    public class DestinationController : Controller
    {
        DestinationManager _destinationManager = new DestinationManager(new EfDestinationDal());
        public IActionResult Index()
        {
            var values = _destinationManager.TGetList();
            return View(values);
        }


        [HttpGet]
        public IActionResult DestinationDetails(int id)
        {
            ViewBag.i = id;
            ViewBag.destID = id;
            var values = _destinationManager.TGetById(id);   
            return View(values);
        }

        [HttpPost]
        public IActionResult DestinationResult(Destination destination)
        {
            return View();
        }


    }
}



