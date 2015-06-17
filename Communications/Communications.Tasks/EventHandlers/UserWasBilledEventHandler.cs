using Billing.Contracts.Public.Events.v1;
using Communications.Contracts.Public.Commands.v1;
using NServiceBus;

namespace Communications.Tasks.EventHandlers
{
    public class UserWasBilledEventHandler : IHandleMessages<IUserWasBilledEvent>
    {
        private readonly IBus bus;

        public UserWasBilledEventHandler(IBus bus)
        {
            this.bus = bus;
        }

        public void Handle(IUserWasBilledEvent message)
        {
            bus.SendLocal<ISendBillingMessage>((x) =>
            {
                x.Email = message.Email;
            });
        }
    }

}
