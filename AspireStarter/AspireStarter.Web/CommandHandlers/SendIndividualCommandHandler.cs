using MassTransit;
using Messaging.Commands;

namespace AspireStarter.Web.CommandHandlers;

public class SendIndividualCommandHandler : IConsumer<ISendIndividual>
{
    private readonly ILogger<SendIndividualCommandHandler> _logger = default!;
    
    
    public SendIndividualCommandHandler(ILogger<SendIndividualCommandHandler> logger)
    {
        _logger = logger;
    }
    public async Task Consume(ConsumeContext<ISendIndividual> context)
    {
        _logger.LogInformation($"ISendIndividual is consumed, {context.Message.CommandId}");
    }
}