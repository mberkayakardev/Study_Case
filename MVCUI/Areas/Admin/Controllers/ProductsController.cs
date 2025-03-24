using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using MVCUI.Models;

namespace MVCUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class ProductsController : Controller
    {
        private readonly HttpClient _httpClient;
        private readonly AppConfigReadModel _Config;
        public ProductsController(IHttpClientFactory httpClient, IOptions<AppConfigReadModel> config)
        {

            _httpClient = httpClient.CreateClient();
            _Config = config.Value;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }


    }
}
