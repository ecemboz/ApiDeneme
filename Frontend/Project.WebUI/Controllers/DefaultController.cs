using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Project.WebUI.Dtos.ServiceDto;
using Project.WebUI.Dtos.SubscribeDto;
using System.Text;

namespace Project.WebUI.Controllers
{
	public class DefaultController : Controller
	{
        private readonly IHttpClientFactory _httpClientFactory;

        public DefaultController (IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public IActionResult Index()
		{
			return View();
		}

		[HttpGet]
		public PartialViewResult _SubscribePartial()
		{
            return PartialView();
        }

		[HttpPost]
        public async Task<IActionResult> _SubscribePartial(CreateSubscribeDto createSubscribeDto)
		{
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(createSubscribeDto);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PostAsync("https://localhost:7198/api/Subscribe", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
