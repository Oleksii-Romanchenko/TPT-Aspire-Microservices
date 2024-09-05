using MassTransit;
using Messaging.Commands;

namespace AspireStarter.Web.EventHandlers;

public class IIndividualCheckedEventHandler : IConsumer<IIndividualChecked>
{
    private ILogger<IIndividualCheckedEventHandler> _logger;
    public IIndividualCheckedEventHandler(ILogger<IIndividualCheckedEventHandler> logger)
    {
        _logger = logger;
    }
    public async Task Consume(ConsumeContext<IIndividualChecked> context)
    {
        _logger.LogWarning("Event is consumed");
    }
}