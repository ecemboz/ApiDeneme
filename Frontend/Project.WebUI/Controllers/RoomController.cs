using Microsoft.AspNetCore.Mvc;

namespace Project.WebUI.Controllers
{
    public class RoomController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
