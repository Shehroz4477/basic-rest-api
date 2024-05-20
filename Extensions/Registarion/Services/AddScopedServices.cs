using basic_rest_api.Interfaces;
using basic_rest_api.Services;

namespace basic_rest_api.Extensions.Registarion.Services;
public static class ScopedServiceCollectionExtension
{
    public static IServiceCollection AddScopedServices(this IServiceCollection services)
    {
        services.AddScoped<IScopedService,ScopedService>();
        services.AddScoped<IPostService,PostService>();
        return services;
    }
}