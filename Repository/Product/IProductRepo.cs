using Entities.QueryFilters;
using E = FeatureApp.Entities;

namespace Repository.Product
{
    public interface IProductRepo
    {
        Task<IList<E.Product>> GetAllProductsAsync();
        Task<IQueryable<E.Product>> GetAllRecordsAsQueryable();
        Task<E.Product> GetProductByIdAsync(Guid Id);
        Task AddProductAsync(E.Product product);
        Task AddRangeProductsAsync(List<E.Product> products);
        Task UpdateProductAsync(E.Product product);
        Task UpdateMultipleProductsAsync(IEnumerable<E.Product> products);
        Task DeleteProductAsync(Guid Id);
        Task DeleteRangeProductAsync(List<Guid> Ids);
    }
}