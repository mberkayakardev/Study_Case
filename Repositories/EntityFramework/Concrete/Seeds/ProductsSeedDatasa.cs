using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repositories.EntityFramework.Concrete.Seeds
{
    public class ProductsSeedDatasa : IEntityTypeConfiguration<Products>
    {
        public void Configure(EntityTypeBuilder<Products> builder)
        {
            List<Products> products = new(){
                new Products
                {
                     Id = 1,
                    IsActive = true,
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now,
                    CreatedUserId = null,
                    CreatedUserName = "Seed Data",
                    ModifiedUserId = null,
                     ModifiedUserName = "Seed Data",
                     ProductName = "Iphone 14",
                     ProductDescription = "128 gb lık versiyon",
                     ProductPrice =20000,
                     ProductCardImage = "https://cdn.vatanbilgisayar.com/Upload/PRODUCT/apple/thumb/0003-mpuf3tu-a_large.jpg",
                     CategoryId = 1
                },
                new Products()
                {
                     Id = 2,
                    IsActive = true,
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now,
                    CreatedUserId = null,
                    CreatedUserName = "Seed Data",
                    ModifiedUserId = null,
                     ModifiedUserName = "Seed Data",
                     ProductName = "Samsung S24 FE",
                     ProductDescription = "128 gb lık versiyon",
                     ProductPrice =15000,
                     ProductCardImage = "https://encrypted-tbn2.gstatic.com/shopping?q=tbn:ANd9GcTNtyK9OXNPvPrrO8AO3JpPGtv9lOTvDRfKku6m3ZqtaO0KRwPUAYmJjgQYoRJLY5HfSoBx4dCkd9O57yAbVdNxGrxgUKmT",
                     CategoryId = 1

                },
                new Products()
                {
                    Id = 3,
                    IsActive = true,
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now,
                    CreatedUserId = null,
                    CreatedUserName = "Seed Data",
                    ModifiedUserId = null,
                    ModifiedUserName = "Seed Data",
                    ProductName = "Monster Laptop",
                    ProductDescription = "Yazilimci Bilgisayarı",
                    ProductPrice =40000,
                    ProductCardImage = "https://m.media-amazon.com/images/I/61tOfogRfXL.__AC_SX300_SY300_QL70_ML2_.jpg",
                    CategoryId = 2

                },
                new Products()
                {
                    Id = 4,
                    IsActive = true,
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now,
                    CreatedUserId = null,
                    CreatedUserName = "Seed Data",
                    ModifiedUserId = null,
                    ModifiedUserName = "Seed Data",
                    ProductName = "ssd ",
                    ProductDescription = "500 Gb",
                    ProductPrice =1000,
                    ProductCardImage = "https://encrypted-tbn0.gstatic.com/shopping?q=tbn:ANd9GcSXIJhS_a--H2uKCFDS5BEYT41Vhmf717hT06Z9ySrFl4R_7p6tWkfUwXvyb-zQJJz9JDlOgVE5lxZa0Hr0u3eN4_YOfJk9n6S1V9JAuKqJIFPhpaYTP42Vfw",
                    CategoryId = 3

                },

            };

            builder.HasData(products);
        }
    }
}
