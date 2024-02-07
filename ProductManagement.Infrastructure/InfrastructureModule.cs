using Microsoft.Extensions.DependencyInjection;
using ProductManagement.Domain.Repositories;
using ProductManagement.Infrastructure.Persistence.Repositories;

namespace ProductManagement.Infrastructure;

public static class InfrastructureModule
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        services.AddScoped<IProductServiceRepository, ProductServiceRepository>();

        return services;
    }
}