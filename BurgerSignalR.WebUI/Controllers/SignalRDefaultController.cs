﻿using Microsoft.AspNetCore.Mvc;

namespace BurgerSignalR.WebUI.Controllers
{
    public class SignalRDefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Index2()
        {
            return View();
        }
    }
}