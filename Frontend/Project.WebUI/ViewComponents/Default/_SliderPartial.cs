using Microsoft.AspNetCore.Mvc;

namespace Project.WebUI.ViewComponents.Default
{
	public class _SliderPartial : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
