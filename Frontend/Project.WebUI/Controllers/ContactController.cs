using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Project.WebUI.Dtos.BookingDto;
using Project.WebUI.Dtos.ContactDto;
using System.Net.Http;
using System.Text;

namespace Project.WebUI.Controllers
{
	public class ContactController : Controller
	{
		private readonly IHttpClientFactory _httpClientFactory;
		public ContactController(IHttpClientFactory httpClientFactory)
		{
			_httpClientFactory = httpClientFactory;
		}
		public IActionResult Index()
		{
			return View();
		}

		[HttpGet]
		public PartialViewResult SendMessage()
		{
			return PartialView();
		}

		[HttpPost]
		public async Task<IActionResult> SendMessage(CreateContactDto createContactDto)
		{
			createContactDto.Date = DateTime.Parse(DateTime.Now.ToShortDateString());
			var client = _httpClientFactory.CreateClient();
			var jsonData = JsonConvert.SerializeObject(createContactDto);
			StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
			var responseMessage = await client.PostAsync("https://localhost:7198/api/Contactt", stringContent);
			return RedirectToAction("Index", "Default");
		}
	}
}
