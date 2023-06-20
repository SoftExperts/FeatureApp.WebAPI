using Database;
using Entities.QueryFilters;
using FeatureApp.Entities;
using Microsoft.IdentityModel.Tokens;
using Repository.Genric;
using E = FeatureApp.Entities;

namespace Repository.Product
{
    public class ProductRepo : IProductRepo
    {
        private readonly IGenericRepo<E.Product> genericRepo;

		public ProductRepo(IGenericRepo<E.Product> genricRepo)
		{
            this.genericRepo = genricRepo;
		}

        public async Task AddProductAsync(E.Product product)
        {
			try
			{
				if(product == null)
				{
					throw new ArgumentNullException(nameof(product));
				}
				else
				{
					await genericRepo.AddWithSaveAsync(product);
				}
			}
			catch (Exception)
			{

				throw;
			}
        }

        public async Task AddRangeProductsAsync(List<E.Product> products)
		{
			try
			{
                if (products == null && products.Count == 0)
				{
                    throw new ArgumentNullException(nameof(products));
                }
                else
				{
                    await genericRepo.AddRangeWithSaveAsync(products);
                }
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
                var product = await genericRepo.GetByIdAsync(Id);
               
				await genericRepo.DeleteWithSaveAsync(product);
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
				if(Ids.Count != 0 && !Ids.IsNullOrEmpty())
				{
                    List<E.Product> products = new();

                    foreach (var Id in Ids)
                    {
                        var product = await genericRepo.GetByIdAsync(Id);
                        products.Add(product);
                    }

                    await genericRepo.DeleteRangeWithSaveAsync(products);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<IList<E.Product>> GetAllProductsAsync()
		{
			try
			{
				return await genericRepo.GetAllRecords<E.Product>();

			}
            catch (Exception ex)
            {

                throw new Exception($"{ex.Message}");
            }
        }

         public async Task<IQueryable<E.Product>> GetAllRecordsAsQueryable()
		 {
			try
			{
				return await genericRepo.GetAllRecordsAsQueryable<E.Product>();
			}
			catch (Exception)
			{

				throw;
			}
		 }

        public async Task<E.Product> GetProductByIdAsync(Guid id)
        {
			try
			{
				return await genericRepo.GetByIdAsync(id);
			}
			catch (Exception)
			{

				throw;
			}
        }

        public async Task UpdateProductAsync(E.Product product)
        {
            try
            {
                await genericRepo.UpdateWithSaveAsync(product);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task UpdateMultipleProductsAsync(IEnumerable<E.Product> products)
        {
            try
            {
                await genericRepo.UpdateRangeWithSaveAsync(products);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
