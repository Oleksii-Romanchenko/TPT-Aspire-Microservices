using System.Reflection;
using MassTransit;
using Microsoft.Extensions.DependencyInjection;

namespace Messaging;

public static class Extensions
{
    public static IServiceCollection WithMassTransitTransport(this IServiceCollection services,
        string host)
    {
        var callingAssembly = Assembly.GetCallingAssembly();
        
        services.AddMassTransit(x =>
        {
            x.AddConsumers(callingAssembly);
            x.UsingRabbitMq((context, cfg) =>
            {
                cfg.Host(host);

                cfg.ConfigureEndpoints(context);
            });
        });

        return services;
    }
}