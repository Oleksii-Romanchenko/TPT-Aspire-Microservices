namespace Messaging.Commands;

public interface IIndividualChecked
{
    Guid CommandId { get; }
    DateTime Timestamp { get; }
    Guid IndividualId { get; }
    string FirstName { get; }
    string LastName { get; }
    ICollection<Guid> Organisations {get;}
}