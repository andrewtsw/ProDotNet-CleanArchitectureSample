using Microsoft.Extensions.DependencyInjection;

namespace CleanArchitecture.Services
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<IOrdersService, OrdersService>();

            return services;
        }
    }
}
