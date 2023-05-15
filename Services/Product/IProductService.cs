using DTOs;

namespace Services.Product
{
    public interface IProductService
    {
        Task AddProduct(ProductDto productDto);
        Task<IEnumerable<ProductDto>> GetAllProducts();
    }
}