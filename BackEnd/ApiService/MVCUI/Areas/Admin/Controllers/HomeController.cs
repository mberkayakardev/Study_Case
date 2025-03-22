using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using MVCUI.Models;
using System.Net.Http;

namespace UI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        private readonly HttpClient _httpClient;
        private readonly AppConfigReadModel _Config;
        public HomeController(IHttpClientFactory httpClient, IOptions<AppConfigReadModel>  config)
        {

            _httpClient = httpClient.CreateClient();
            _Config = config.Value;
        }

        public async Task <IActionResult> Index()
        {
            var response = await _httpClient.GetAsync($"{_Config.BaseUrl}/products");

            return View();
        }
    }
}
