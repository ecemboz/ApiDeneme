using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Project.WebUI.Dtos.AboutDto;
using Project.WebUI.Dtos.ServiceDto;

namespace Project.WebUI.ViewComponents.Default
{
	public class _AboutUsPartial : ViewComponent
	{
		private readonly IHttpClientFactory _httpClientFactory;
		public _AboutUsPartial(IHttpClientFactory httpClientFactory)
		{
			_httpClientFactory = httpClientFactory;
		}

		public async Task<IViewComponentResult> InvokeAsync()
		{
			var client = _httpClientFactory.CreateClient();
			var responseMessage = await client.GetAsync("https://localhost:7198/api/About");
			if (responseMessage.IsSuccessStatusCode)
			{
				var jsonData = await responseMessage.Content.ReadAsStringAsync();
				var values = JsonConvert.DeserializeObject<List<ResultAboutDto>>(jsonData);
				return View(values);
			}
			return View();
		}
	}
}
