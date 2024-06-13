using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Project.WebUI.Dtos.BookingDto;
using System.Text;

namespace Project.WebUI.Controllers
{
    public class BookingController : Controller
    {
		private readonly IHttpClientFactory _httpClientFactory;
		public BookingController(IHttpClientFactory httpClientFactory)
		{
			_httpClientFactory = httpClientFactory;
		}

		public IActionResult Index()
		{
			return View();
		}

		[HttpGet]
		public PartialViewResult AddBooking()
		{
			return PartialView();
		}

		[HttpPost]
        public async Task<IActionResult> AddBooking(CreateBookingDto createBookingDto)
        {
			createBookingDto.Status = "Onay Bekliyor";
			createBookingDto.Description = string.IsNullOrEmpty(createBookingDto.Description) ? string.Empty : createBookingDto.Description;
			var client = _httpClientFactory.CreateClient();
			var jsonData = JsonConvert.SerializeObject(createBookingDto);
			StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
			var responseMessage = await client.PostAsync("https://localhost:7198/api/Bookingg", stringContent);
            return RedirectToAction("Index", "Default");
		}
    }
}
