﻿using Microsoft.AspNetCore.Mvc;

namespace BurgerSignalR.WebUI.ViewComponents.LayoutComponents
{
    public class _LayoutFooterComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
