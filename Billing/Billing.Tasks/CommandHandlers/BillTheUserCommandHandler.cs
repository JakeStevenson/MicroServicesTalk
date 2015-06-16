using System.Diagnostics;
using Billing.Contracts.Public;
using Billing.Contracts.Public.Events;
using NServiceBus;

namespace Billing.Tasks.CommandHandlers
{
    public class BillTheUserCommandHandler : IHandleMessages<BillTheUserCommand>
    {
        private readonly IBus bus;

        public BillTheUserCommandHandler(IBus bus)
        {
            this.bus = bus;
        }

        public void Handle(BillTheUserCommand message)
        {
            Debug.WriteLine("Billing {0}", message.Email);
            bus.Publish(new UserWasBilledEvent() { Email = message.Email });
        }
    }
}
