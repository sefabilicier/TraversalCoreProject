﻿using BusinessLayer.Concretes;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.ViewComponents.MemberDashBoard
{
    public class _GuideList : ViewComponent
    {

        GuideManager guideManager = new GuideManager(new EfGuideDal());
        public IViewComponentResult Invoke(int id)
        {
            var values = guideManager.TGetList();
            return View(values);
        }
    } 
}
