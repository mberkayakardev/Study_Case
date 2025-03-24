using Core.Extentions.Concrete.Controller.Api;
using Core.Utilities.Results.MVC.BaseResult;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using Services.Abstract;

namespace WebApi.Controllers
{
    public class ProductsController : CostumeApiController
    {
        private readonly IProductService _productService;
        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet(Name = "products")]
        public async Task<IActionResult> GetProductListForLanding([FromQuery] int? CategoryIdList)
        {
            return ActionResultInstance(await _productService.GetAllProductsWithLandingPage(CategoryIdList));
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetCategoriesListForLanding(int id)
        {
            return ActionResultInstance(await _productService.GetProductByProductId(id));
        }


        //[HttpPost(Name = "products")]
        //public async Task<IActionResult> CreateProduct(CreateProductDto)
        //{
        //    return ActionResultInstance(await _productService.GetAllProductsWithLandingPage(CategoryIdList));
        //}



        //[HttpGet(Name = "categories/{CategoryIdList}")]
        //public async Task<IActionResult> GetProductWithCategoryListForLanding([FromQuery]int? CategoryIdList)
        //{
        //    return ActionResultInstance( await _productService.GetAllProductsWithLandingPage(CategoryIdList));
        //}
    }
}
