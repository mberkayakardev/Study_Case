using AutoMapper;
using Core.Utilities.Results.MVC.BaseResult;
using Dtos.Concrete.Products;
using Entities.Concrete;
using QuizApp.Repositories.EntityFramework.Abstract;
using QuizApp.Services.Abstract.Base;
using Services.Abstract;

namespace Services.Concrete.Services
{
    public class ProductManager : BaseServices, IProductService
    {
        public ProductManager(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public async Task<IApiDataResult<List<ListProductDto>>> GetAllProductsWithLandingPage(int? CategoryIdList)
        {
            var repository = await _unitOfWork.GetGenericRepositories<Products>().GetAllAsync(x => x.IsActive == true && (CategoryIdList.HasValue ? x.CategoryId == CategoryIdList : true));
            if (repository != null && repository.Count > 0)
            {
                var MappedProduct = _mapper.Map<List<ListProductDto>>(repository);
                return new ApiDataResult<List<ListProductDto>>(MappedProduct, Core.Utilities.Results.MVC.ComplexTypes.ApiResultStatus.Ok);
            }

            return new ApiDataResult<List<ListProductDto>>(null, Core.Utilities.Results.MVC.ComplexTypes.ApiResultStatus.NotFound);

        }
    }
}
