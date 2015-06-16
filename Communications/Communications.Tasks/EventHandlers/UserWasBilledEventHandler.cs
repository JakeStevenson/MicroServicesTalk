using Billing.Contracts.Public.Events;
using Communications.Contracts.Public.Commands;
using NServiceBus;

namespace Communications.Tasks.EventHandlers
{
    public class UserWasBilledEventHandler : IHandleMessages<UserWasBilledEvent>
    {
        private readonly IBus bus;

        public UserWasBilledEventHandler(IBus bus)
        {
            this.bus = bus;
        }

        public void Handle(UserWasBilledEvent message)
        {
            bus.Send(new SendBillingMessage(){Email = message.Email});
        }
    }

}
