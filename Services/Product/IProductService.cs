using DTOs;
using Entities.QueryFilters;

namespace Services.Product
{
    public interface IProductService
    {
        Task AddProductAsync(ProductDto productDto);
        Task AddRangeProductsAsync(List<ProductDto> productDtos);
        Task<IEnumerable<ProductDto>> GetAllProductsAsync();
        Task<IEnumerable<ProductDto>> GetAllRecordsAsQueryable(ProductQueryParameter queryParameters);
        Task<ProductDto> GetProductByIdAsync(Guid id);
        Task UpdateProductAsync(ProductDto productDto);        
        Task UpdateMultipleProductsAsync(IEnumerable<ProductDto> productDtos);        
        Task DeleteProductAsync(Guid Id);
        Task DeleteRangeProductAsync(List<Guid> Ids);
    }
}