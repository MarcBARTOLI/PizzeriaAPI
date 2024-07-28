using PizzeriaAPI.Application.Mediator;

namespace PizzeriaAPI.ApiService;

public static class AppServices
{
    public static IServiceCollection AddAppServices(this IServiceCollection services)
    {
        services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies([typeof(IQuery<>).Assembly]));

        return services;
    }
}