using AutoMapper;
using Dtos.Concrete.Products;
using Entities.Concrete;

namespace Services.Concrete.MappingProfiles
{
    public class ProductMappingProfiles : Profile
    {
        public ProductMappingProfiles()
        {
            CreateMap<Products, ListProductDto>().ReverseMap();
        }
    }
}
