using CleanArchitecture.Application.Interfaces.Orders;
using CleanArchitecture.Application.Orders;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArchitecture.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IOrdersService, OrdersService>();

            return services;
        }
    }
}
