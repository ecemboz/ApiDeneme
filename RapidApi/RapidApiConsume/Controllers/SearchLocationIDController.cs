using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RapidApiConsume.Models;
using System.Net.Http.Headers;

namespace RapidApiConsume.Controllers
{
	public class SearchLocationIDController : Controller
	{
		public async Task<IActionResult> Index(string cityName)
		{
			if(!string.IsNullOrEmpty(cityName))
			{
				List<BookingApiLocationSearchViewModel> model = new List<BookingApiLocationSearchViewModel>();

				var client = new HttpClient();
				var request = new HttpRequestMessage
				{
					Method = HttpMethod.Get,
					RequestUri = new Uri($"https://booking-com.p.rapidapi.com/v1/hotels/locations?name={cityName}&locale=en-gb"),
					Headers =
				{
					{ "x-rapidapi-key", "defad02db1msh7713c1b95666236p10d718jsnae28f74aa43e" },
					{ "x-rapidapi-host", "booking-com.p.rapidapi.com" },
				},
				};
				using (var response = await client.SendAsync(request))
				{
					response.EnsureSuccessStatusCode();
					var body = await response.Content.ReadAsStringAsync();
					model = JsonConvert.DeserializeObject<List<BookingApiLocationSearchViewModel>>(body);
					return View(model.Take(1).ToList());
				}
			}

			else
			{
				List<BookingApiLocationSearchViewModel> model = new List<BookingApiLocationSearchViewModel>();

				var client = new HttpClient();
				var request = new HttpRequestMessage
				{
					Method = HttpMethod.Get,
					RequestUri = new Uri("https://booking-com.p.rapidapi.com/v1/hotels/locations?name=Paris&locale=en-gb"),
					Headers =
				{
					{ "x-rapidapi-key", "defad02db1msh7713c1b95666236p10d718jsnae28f74aa43e" },
					{ "x-rapidapi-host", "booking-com.p.rapidapi.com" },
				},
				};
				using (var response = await client.SendAsync(request))
				{
					response.EnsureSuccessStatusCode();
					var body = await response.Content.ReadAsStringAsync();
					model = JsonConvert.DeserializeObject<List<BookingApiLocationSearchViewModel>>(body);
					return View(model.Take(1).ToList());
				}
			}
		}
	}
}
