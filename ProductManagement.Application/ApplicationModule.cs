using Microsoft.Extensions.DependencyInjection;
using ProductManagement.Application.Services;
using ProductManagement.Application.Services.Interfaces;

namespace ProductManagement.Application;

public static class ApplicationModule
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddScoped<IProductService, ProductService>();

        return services;
    }
}