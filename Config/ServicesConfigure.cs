using Microsoft.Extensions.DependencyInjection;
using Services.Product;

namespace Config
{
    /// <summary>
    /// AddAndConfigure Services
    /// </summary>
    public static class ServicesConfigure
    {
        /// <summary>
        /// AddAndConfigureServices
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddAndConfigureServices(this IServiceCollection services)
        {
            // Common
            services.AddTransient<IProductService, ProductService>();
            services.AddSignalR();
            return services;
        }
    }
}