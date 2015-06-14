using CleanAir4You.Bus;
using CleanAir4You.Contracts;
using CleanAir4You.Contracts.Billing.Events;
using CleanAir4You.Contracts.Comunications.Commands;

namespace CleanAir4You.Tasks.Communications.EventHandlers
{
    public class UserWasBilledEventHandler : ISubscribe<UserWasBilledEvent>
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
