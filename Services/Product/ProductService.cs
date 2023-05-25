using DTOs;
using FeatureApp.Entities;
using Repository.Product;
using System.Diagnostics;
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

        public async Task AddProductAsync(ProductDto productDto)
        {
            try
            {
                E.Product product = SetProductEntity(productDto);

                await productRepo.AddProductAsync(product);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task AddRangeProductsAsync(List<ProductDto> productDtos)
        {
            try
            {
                List<E.Product> productDtosList = new();

                var products = productDtos.Select(x => SetProductEntity(x));

                productDtosList.AddRange(products);                             

                await productRepo.AddRangeProductsAsync(productDtosList);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<IEnumerable<ProductDto>> GetAllProductsAsync()
        {
            try
            {
               var res = await productRepo.GetAllProductsAsync();

               return res.Select(x => SetProductDto(x));
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<ProductDto>GetProductByIdAsync(Guid Id)
        {
            try
            {
                var product = await productRepo.GetProductByIdAsync(Id);

                return SetProductDto(product);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task UpdateProductAsync(ProductDto productDto)
        {
            try
            {
                var product = SetProductEntity(productDto);

                await productRepo.UpdateProductAsync(product);              
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task UpdateMultipleProductsAsync(IEnumerable<ProductDto> productDtos)
        {
            try
            {
                var products = productDtos.Select(x => SetProductEntity(x));

                await productRepo.UpdateMultipleProductsAsync(products);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task DeleteProductAsync(Guid Id)
        {
            try
            {
                await productRepo.DeleteProductAsync(Id);
            }
            catch (Exception)
            {

                throw;
            }
        }
        
        public async Task DeleteRangeProductAsync(List<Guid> Ids)
        {
            try
            {
                await productRepo.DeleteRangeProductAsync(Ids);
            }
            catch (Exception)
            {

                throw;
            }
        }

        #endregion

        #region Private Methods Region

        private static E.Product SetProductEntity(ProductDto productDto)
        {
            var product = new E.Product();
            
            if (productDto.IsNew)
            {              
                product.CreatedDate = DateTime.Now;
            }
            else
            {
                product.ModifiedDate = DateTime.Now;                
            }

            productDto.IsNew = false;
            product.Id = productDto.Id;
            product.IsActive = productDto.IsActive;
            product.Name = productDto.Name;
            product.Description = productDto.Description;
            product.Sku = productDto.Sku;
            product.IsAvailable = productDto.IsAvailable;
            product.Price = productDto.Price;

            return product;
        }

        private static ProductDto SetProductDto(E.Product res)
        {
            ProductDto productDto = new()
            {
                Id = res.Id,
                Name = res.Name,
                Description = res.Description,
                Price = res.Price, 
                Sku = res.Sku,
                CreatedDate = res.CreatedDate,
                IsAvailable = res.IsAvailable,
                CreatedBy = res.CreatedBy,
                IsActive = res.IsActive,
            };

            return productDto;
        }

        #endregion
    }
}
