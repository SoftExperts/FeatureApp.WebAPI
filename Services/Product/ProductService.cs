using DTOs;
using FeatureApp.Entities;
using Repository.Product;
using E = FeatureApp.Entities;

namespace Services.Product
{
    public class ProductService : IProductService
    {
        private readonly IProductRepo productRepo;
        public ProductService(IProductRepo productRepo)
        {
            this.productRepo = productRepo;
        }

        #region Public Methods Region

        public async Task AddProduct(ProductDto productDto)
        {
            try
            {
                E.Product product = SetProductEntity(productDto);

                await productRepo.AddProduct(product);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<IEnumerable<ProductDto>> GetAllProducts()
        {
            try
            {
               var res = await productRepo.GetAllProducts();
               return res.Select(x => SetProductDto(x));
            }
            catch (Exception)
            {

                throw;
            }
        }

     


        #endregion

        #region Private Methods Region
        private E.Product SetProductEntity(ProductDto productDto)
        {
            return new E.Product()
            {
                IsActive= productDto.IsActive,
                Name= productDto.Name,
                Description= productDto.Description,
                Sku= productDto.Sku,
                CreatedDate= DateTime.Now,
                IsAvailable= productDto.IsAvailable,
                Price  = productDto.Price,
            };
        }

        private ProductDto SetProductDto(E.Product res)
        {
            return new ProductDto()
            {
                Name = res.Name,
                Description = res.Description,
                Price = res.Price, 
                Sku= res.Sku,
            };

        }

        #endregion
    }
}
