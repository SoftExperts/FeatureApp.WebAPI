using E = FeatureApp.Entities;

namespace Repository.Product
{
    public interface IProductRepo
    {
        Task AddProduct(E.Product product);
        Task<IList<E.Product>> GetAllProducts();
    }
}