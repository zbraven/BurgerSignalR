using Microsoft.AspNetCore.Mvc;

namespace BurgerSignalR.WebUI.ViewComponents.LayoutComponents
{
	public class _LayoutNavbarComponentPartial : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}

	}
}
