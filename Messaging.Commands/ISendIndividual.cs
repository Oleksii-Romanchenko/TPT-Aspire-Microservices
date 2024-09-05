
namespace Messaging.Commands;

public interface ISendIndividual
{
    Guid CommandId { get; }
    DateTime Timestamp { get; }
    Guid IndividualId { get; }
    string FirstName { get; }
    string LastName { get; }
    ICollection<Guid> Organisations {get;}
}