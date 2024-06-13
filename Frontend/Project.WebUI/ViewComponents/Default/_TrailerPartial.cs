using Microsoft.AspNetCore.Mvc;

namespace Project.WebUI.ViewComponents.Default
{
	public class _TrailerPartial : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
