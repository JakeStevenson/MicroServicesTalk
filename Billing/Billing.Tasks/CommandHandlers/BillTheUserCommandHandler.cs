using System;
using Billing.Contracts.Public.Commands.v1;
using Billing.Contracts.Public.Events.v1;
using NServiceBus;

namespace Billing.Tasks.CommandHandlers
{
    public class BillTheUserCommandHandler : IHandleMessages<IBillTheUserCommand>
    {
        private readonly IBus bus;

        public BillTheUserCommandHandler(IBus bus)
        {
            this.bus = bus;
        }

        public void Handle(IBillTheUserCommand message)
        {
            Console.WriteLine("Billing {0}", message.Email);
            bus.Publish<IUserWasBilledEvent>((x) =>
            {
                x.Email = message.Email;
            });
        }
    }
}
