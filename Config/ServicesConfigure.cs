using Microsoft.Extensions.DependencyInjection;
using Services.Product;
using Services.SecurityAttacks;

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
            services.AddTransient<ISecurityAttacks, SecurityAttacks>();
            services.AddSignalR();
            return services;
        }
    }
}