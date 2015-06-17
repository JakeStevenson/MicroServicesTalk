using NServiceBus;

namespace AccountManagement.Contracts.Public.Events.v1
{
    public interface IUserHasSignedUp : IEvent
    {
        string Email { get; set; }
        string Name { get; set; }
    }
}
