using Microsoft.AspNetCore.Mvc;

namespace Project.WebUI.ViewComponents.Default
{
	public class _FooterPartial : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
