using BusinessLayer.Concretes;
using DataAccessLayer.Abstracts;
using DataAccessLayer.Concretes;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.ViewComponents.Default
{
    public class _Feature : ViewComponent
    {
        
        FeatureManager featureManager = new FeatureManager(new EfFeatureDal());

        public IViewComponentResult Invoke()
        {
            //var values = featureManager.TGetList();

            return View();  

        }

        

    }
}
