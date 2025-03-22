using Core.Utilities.Results.MVC.BaseResult;
using Dtos.Concrete.Categories;
using Dtos.Concrete.Products;
using QuizApp.Services.Abstract.Base;

namespace Services.Abstract
{
    public interface ICategoryService : IBaseServices
    {
        Task<IApiDataResult<List<ListCategoriesDto>>> GetAllCategoriesWithLandingPage();


    }
}
