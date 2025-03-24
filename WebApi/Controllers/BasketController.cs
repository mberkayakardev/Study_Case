using Core.Extentions.Concrete.Controller.Api;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    public class BasketController : CostumeApiController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
