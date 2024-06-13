using Microsoft.AspNetCore.Mvc;

namespace Project.WebUI.ViewComponents.Contact
{
	public class _ContactCoverPartial:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
