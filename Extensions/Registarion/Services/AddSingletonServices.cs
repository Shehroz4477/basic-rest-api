using basic_rest_api.Interfaces;
using basic_rest_api.Services;

namespace basic_rest_api.Extensions.Registarion.Services;
public static class SingletonServiceCollection
{
    public static IServiceCollection AddSingletonServices(this IServiceCollection services)
    {
        services.AddSingleton<ISingletonService,SingletonService>();
        services.AddSingleton<IDemoService,DemoService>();
        return services;
    }
}