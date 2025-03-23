using AutoMapper;
using Core.Utilities.Managers;
using Core.Utilities.Results.MVC.BaseResult;
using Core.Utilities.Results.MVC.ComplexTypes;
using Dtos.Concrete.Categories;
using Entities.Concrete;
using QuizApp.Repositories.EntityFramework.Abstract;
using QuizApp.Services.Abstract.Base;
using Services.Abstract;
using Services.Concrete.Messages;

namespace Services.Concrete.Services
{
    public class CategoryManager : BaseServices, ICategoryService
    {
        private readonly MemoryCacheManager _cacheManager;
        public CategoryManager(IUnitOfWork unitOfWork, IMapper mapper, MemoryCacheManager cacheManager) : base(unitOfWork, mapper)
        {
            _cacheManager = cacheManager;
        }

        public async Task<IApiDataResult<List<ListCategoriesDto>>> GetAllCategoriesWithLandingPage()
        {
            var memroyCachedata = _cacheManager.Get<List<ListCategoriesDto>>(ConstVerables.AllActiveCategoryCacheKey);
            if (memroyCachedata == null || memroyCachedata.Count == 0)
            {
                var result = await _unitOfWork.GetGenericRepositories<Categories>().GetAllAsync(x => x.IsActive == true);
                if (result != null && result.Count>0)
                {
                    var MappedData = _mapper.Map<List<ListCategoriesDto>>(result);
                    _cacheManager.Create<List<ListCategoriesDto>>(ConstVerables.AllActiveCategoryCacheKey, MappedData);
                    return new ApiDataResult<List<ListCategoriesDto>>(MappedData, ApiResultStatus.Ok);
                }
                return new ApiDataResult<List<ListCategoriesDto>>(null,ApiResultStatus.NotFound);

            }
            return new ApiDataResult<List<ListCategoriesDto>>(memroyCachedata, ApiResultStatus.Ok); ;

        }
    }
}
