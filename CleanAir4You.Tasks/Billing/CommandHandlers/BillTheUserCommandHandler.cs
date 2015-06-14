using System.Diagnostics;
using CleanAir4You.Bus;
using CleanAir4You.Contracts;
using CleanAir4You.Contracts.Billing.Commands;
using CleanAir4You.Contracts.Billing.Events;

namespace CleanAir4You.Tasks.Billing.CommandHandlers
{
    public class BillTheUserCommandHandler : IHandle<BillTheUserCommand>
    {
        private readonly IBus bus;

        public BillTheUserCommandHandler(IBus bus)
        {
            this.bus = bus;
        }

        public void Handle(BillTheUserCommand message)
        {
            Debug.WriteLine("Billing {0}", message.Email);
            bus.Publish(new UserWasBilledEvent(){Email = message.Email});
        }
    }
}
