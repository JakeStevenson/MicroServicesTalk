using System;
using AccountManagement.Contracts.Public.Commands.v1;
using AccountManagement.Contracts.Public.Events.v1;
using NServiceBus;

namespace AccountManagement.Tasks.CommandHandlers
{
    public class SignupUserCommandHandler : IHandleMessages<ISignupUserCommand>
    {
        private readonly IBus bus;

        public SignupUserCommandHandler(IBus bus)
        {
            this.bus = bus;
        }

        public void Handle(ISignupUserCommand message)
        {
            Console.WriteLine("Signing up the user {0}", message.Email);
            bus.Publish<IUserHasSignedUp>((x) =>
            {
                x.Email = message.Email;
                x.Name = message.Name;
            });
        }
    }
}
