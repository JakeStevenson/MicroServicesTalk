using NServiceBus;

namespace Billing.Contracts.Public.Events.v1
{
    public interface IUserWasBilledEvent : IEvent
    {
        string Email { get; set; }
    }
}
