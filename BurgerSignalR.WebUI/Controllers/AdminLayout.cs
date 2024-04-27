using Microsoft.AspNetCore.Mvc;

namespace BurgerSignalR.WebUI.Controllers
{
    public class AdminLayout : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
