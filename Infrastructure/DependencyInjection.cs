using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Infrastructure.Persistence;
using Application.Common.Interfaces;

namespace Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationCosmosDbContext>(options =>
                options.UseCosmos(configuration.GetSection("Cosmos:EndPoint").Value,
                configuration.GetSection("Cosmos:Key").Value,
                configuration.GetSection("Cosmos:Database").Value)
            );
            services.AddScoped<IApplicationCosmosDbContext>(provider => provider.GetService<ApplicationCosmosDbContext>());
            services.AddDbContext<ApplicationSqlDbContext>(options =>
                options.UseSqlServer(
                        configuration.GetSection("ConnectionStrings:SqlServerConnection").Value));
            services.AddScoped<IApplicationSqlDbContext>(provider => provider.GetService<ApplicationSqlDbContext>());
            return services;
        }
    }
}
