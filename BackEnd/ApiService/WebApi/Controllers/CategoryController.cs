using Core.Extentions.Concrete.Controller.Api;
using Microsoft.AspNetCore.Mvc;
using Services.Abstract;

namespace WebApi.Controllers
{
    public class CategoryController : CostumeApiController
    {
        private readonly ICategoryService _categoryService;
        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }


        [HttpGet(Name = "categories")]
        public async Task<IActionResult> GetProductListForLanding()
        {
            return ActionResultInstance(await _categoryService.GetAllCategoriesWithLandingPage());
        }
    }
}
