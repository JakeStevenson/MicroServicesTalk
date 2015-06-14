using CleanAir4You.Bus;
using CleanAir4You.Contracts;
using CleanAir4You.Contracts.AccountManagement.Events;
using CleanAir4You.Contracts.Comunications.Commands;

namespace CleanAir4You.Tasks.Communications.EventHandlers
{
    public class UserHasSignedUpEventHandler :ISubscribe<UserHasSignedUp>
    {
        private readonly IBus bus;

        public UserHasSignedUpEventHandler(IBus bus)
        {
            this.bus = bus;
        }

        public void Handle(UserHasSignedUp message)
        {
            bus.Send(new EmailWelcomeMessage(){Email = message.Email, Name = message.Name});
        }
    }
}
