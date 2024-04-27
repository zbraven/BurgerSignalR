using Microsoft.AspNetCore.Mvc;

namespace BurgerSignalR.WebUI.ViewComponents.LayoutComponents
{
    public class _LayoutHeaderPartialComponent:ViewComponent 
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
