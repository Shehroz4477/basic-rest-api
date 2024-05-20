using basic_rest_api.Interfaces;
using basic_rest_api.Services;

namespace basic_rest_api.Extensions.Registarion.Services;
public static class TransientServiceCollection
{
    public static IServiceCollection AddTransientServices(this IServiceCollection services)
    {
        services.AddTransient<ITransientService,TransientService>();
        return services;
    }
}