using Microsoft.AspNetCore.Mvc;

namespace BurgerSignalR.WebUI.Controllers
{
    public class StatisticController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
