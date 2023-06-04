﻿using BusinessLayer.Abstracts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace TraversalCoreProject.ViewComponents.Destination
{
    public class _GuideDetails : ViewComponent
    {
        private readonly IGuideService _guideService;   
        public _GuideDetails(IGuideService guideService)
        {
            _guideService = guideService;
        }   

        public IViewComponentResult Invoke()
        {
            var values = _guideService.TGetById(1);
            return View(values);
        }
    }
}
