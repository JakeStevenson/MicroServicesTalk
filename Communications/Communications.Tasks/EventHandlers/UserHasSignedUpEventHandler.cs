using AccountManagement.Contracts.Public.Events.v1;
using Communications.Contracts.Public.Commands.v1;
using NServiceBus;

namespace Communications.Tasks.EventHandlers
{
    public class UserHasSignedUpEventHandler :IHandleMessages<IUserHasSignedUp>
    {
        private readonly IBus bus;

        public UserHasSignedUpEventHandler(IBus bus)
        {
            this.bus = bus;
        }

        public void Handle(IUserHasSignedUp message)
        {
            bus.SendLocal<IEmailWelcomeMessage>((x)=>
            {
                x.Email = message.Email;
                x.Name = message.Name;
            });
        }
    }

}
