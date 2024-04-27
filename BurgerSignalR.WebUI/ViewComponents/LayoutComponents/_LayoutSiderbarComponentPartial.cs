using Microsoft.AspNetCore.Mvc;

namespace BurgerSignalR.WebUI.ViewComponents.LayoutComponents
{
    public class _LayoutSiderbarComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();  
        }
    }
}
