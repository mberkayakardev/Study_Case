using Core.Extentions.Concrete.Controller.Api;
using Microsoft.AspNetCore.Mvc;
using Services.Abstract;

namespace WebApi.Controllers
{
    public class CategoriesController : CostumeApiController
    {
        private readonly ICategoryService _categoryService;
        private readonly IProductService _productService;
        public CategoriesController(ICategoryService categoryService, IProductService productService)
        {
            _categoryService = categoryService;
            _productService = productService;
        }


        [HttpGet(Name = "categories")]
        public async Task<IActionResult> GetProductListForLanding()
        {
            return ActionResultInstance(await _categoryService.GetAllCategoriesWithLandingPage());
        }

        [HttpGet("{categoryId}/products")]
        public async Task<IActionResult> GetProductsByCategoryId(int categoryId)
        {
            return ActionResultInstance(await _productService.GetAllProductsWithLandingPage(categoryId));
        }

         
    }
}
