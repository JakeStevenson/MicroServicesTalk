using NServiceBus;

namespace AccountManagement.Contracts.Public.Events
{
    public class UserHasSignedUp : IEvent
    {
        public string Email { get; set; }
        public string Name { get; set; }
    }
}
