﻿using Microsoft.AspNetCore.Mvc;

namespace CarAnalysis.ViewComponents
{
    public class HeaderViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
