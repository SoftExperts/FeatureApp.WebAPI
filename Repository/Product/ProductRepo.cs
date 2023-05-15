using Database;
using Repository.Genric;
using E = FeatureApp.Entities;

namespace Repository.Product
{
    public class ProductRepo : IProductRepo
    {
        private readonly IGenericRepo<E.Product> genricRepo;

		public ProductRepo(IGenericRepo<E.Product> genricRepo)
		{
            this.genricRepo = genricRepo;
		}

        public async Task AddProduct(E.Product product)
        {
			try
			{
				if(product == null)
				{
					throw new ArgumentNullException(nameof(product));
				}
				else
				{
					await genricRepo.AddWithSaveAsync(product);
				}
			}
			catch (Exception)
			{

				throw;
			}
        }

		public async Task<IList<E.Product>> GetAllProducts()
		{
			try
			{
				return await genricRepo.GetAllRecords<E.Product>();

			}
			catch (Exception)
			{

				throw;
			}
		}
    }
}
