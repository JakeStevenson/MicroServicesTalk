using Communications.Contracts.Public.Commands;
using NServiceBus;

namespace Communications.Tasks.CommandHandlers
{
    public class SendWelcomeMessageHandler : IHandleMessages<EmailWelcomeMessage>
    {
        public void Handle(EmailWelcomeMessage message)
        {
            //SEND AN EMAIL 
            Console.WriteLine("Sending a welcome email to {0}", message.Email);
        }
    }
}
