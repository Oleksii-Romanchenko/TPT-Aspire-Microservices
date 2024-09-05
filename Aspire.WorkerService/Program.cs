using MassTransit;
using Messaging;
using Messaging.Commands;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

var host = builder.Configuration["Transport:host"];

if (string.IsNullOrEmpty(host))
{
    throw new SystemException("rabbitmq settings are not defined");
}

builder.Services.WithMassTransitTransport(host);

var app = builder.Build();

app.MapGet("/invoke", async ([FromServices]IBus bus) =>
{
   // var endpoint = await bus.GetSendEndpoint(new Uri("exchange:aspire.exchange"));
    await bus.Publish<IIndividualChecked>(new
    {
        CommandId = Guid.NewGuid(),
        
        
    });
});
app.Run();