using System;
using AccountManagement.Contracts.Public;
using AccountManagement.Contracts.Public.Commands;
using AccountManagement.Contracts.Public.Events;
using NServiceBus;

namespace AccountManagement.Tasks.CommandHandlers
{
    public class SignupUserCommandHandler : IHandleMessages<SignupUserCommand>
    {
        private readonly IBus bus;

        public SignupUserCommandHandler(IBus bus)
        {
            this.bus = bus;
        }

        public void Handle(SignupUserCommand message)
        {
            Console.WriteLine("Signing up the user {0}", message.Email);
            bus.Publish(new UserHasSignedUp(){Email = message.Email, Name = message.Name});
        }
    }
}
