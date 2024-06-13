using Microsoft.AspNetCore.Mvc;

namespace Project.WebUI.ViewComponents.Default
{
	public class _HeadPartial:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
