using CleanAir4You.Bus;
using CleanAir4You.Contracts;
using CleanAir4You.Contracts.AccountManagement.Commands;
using CleanAir4You.Contracts.AccountManagement.Events;

namespace CleanAir4You.Tasks.AccountManagement.CommandHandlers
{
    public class SignupUseCommandrHandler : IHandle<SignupUserCommand>
    {
        private readonly IBus bus;

        public SignupUseCommandrHandler(IBus bus)
        {
            this.bus = bus;
        }

        public void Handle(SignupUserCommand userCommand)
        {
            //Register the user from the message
            //Let everyone know we have a new user!
            bus.Publish(new UserHasSignedUp(){Email = userCommand.Email, Name = userCommand.Name});
        }
    }
}
