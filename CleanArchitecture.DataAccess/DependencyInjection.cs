using CleanArchitecture.DataAccess.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArchitecture.DataAccess.SqlServer
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddDataAccessSqlServer(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<IOrdersDbContext, DatabaseContext>(options => options.UseSqlServer(connectionString));

            return services;
        }
    }
}
