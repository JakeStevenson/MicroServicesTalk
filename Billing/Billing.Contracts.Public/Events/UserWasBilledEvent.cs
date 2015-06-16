using NServiceBus;

namespace Billing.Contracts.Public.Events
{
    public class UserWasBilledEvent : IEvent
    {
        public string Email { get; set; }
    }
}
