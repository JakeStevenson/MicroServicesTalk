using AccountManagement.Contracts.Public.Events;
using Communications.Contracts.Public.Commands;
using NServiceBus;

namespace Communications.Tasks.EventHandlers
{
    public class UserHasSignedUpEventHandler :IHandleMessages<UserHasSignedUp>
    {
        private readonly IBus bus;

        public UserHasSignedUpEventHandler(IBus bus)
        {
            this.bus = bus;
        }

        public void Handle(UserHasSignedUp message)
        {
            bus.SendLocal(new EmailWelcomeMessage(){Email = message.Email, Name = message.Name});
        }
    }

}
