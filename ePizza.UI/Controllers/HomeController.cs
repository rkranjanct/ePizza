using ePizza.UI.Models;
using ePizza.UI.Models.ResponseModel;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ePizza.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly HttpClient httpClient;

        public HomeController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
            httpClient = _httpClientFactory.CreateClient("ePizzaApiClient");
        }
        public  async Task<IActionResult> Index()
        {
            var Items = await httpClient.GetFromJsonAsync<List<ResponseModelDto>>("api/Item");
            if(Items is not null)
            {
                return View(Items);
            }
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
