using Microsoft.Extensions.DependencyInjection;
using Repository.Genric;
using Repository.Product;

namespace Config
{
    /// <summary>
    /// Repositories Configure
    /// </summary>
    public static class RepositoriesConfigure
    {
        public static IServiceCollection AddAndConfigureRepositories(this IServiceCollection services)
        {
            // Common
            services.AddTransient(typeof(IGenericRepo<>), typeof(GenericRopo<>));
            services.AddTransient<IProductRepo, ProductRepo>();

            return services;
        }
    }
}