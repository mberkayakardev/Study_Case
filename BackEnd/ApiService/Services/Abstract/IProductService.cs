using Core.Utilities.Results.MVC.BaseResult;
using Dtos.Concrete.Products;
using QuizApp.Services.Abstract.Base;

namespace Services.Abstract
{
    public interface IProductService : IBaseServices
    {
        Task<IApiDataResult<List<ListProductDto>>> GetAllProductsWithLandingPage(int? CategoryIdList); 
    }
}
