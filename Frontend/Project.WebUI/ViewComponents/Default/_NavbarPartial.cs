using Microsoft.AspNetCore.Mvc;

namespace Project.WebUI.ViewComponents.Default
{
	public class _NavbarPartial : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}	
	}
}
