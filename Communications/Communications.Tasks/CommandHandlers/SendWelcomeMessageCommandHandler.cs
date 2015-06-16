using System.Diagnostics;
using Communications.Contracts.Public.Commands;
using NServiceBus;

namespace Communications.Tasks.CommandHandlers
{
    public class SendWelcomeMessageHandler : IHandleMessages<EmailWelcomeMessage>
    {
        public void Handle(EmailWelcomeMessage message)
        {
            //SEND AN EMAIL 
            //THIS CAN BLOCK A WHILE!
            Debug.WriteLine("Sending a welcome email to {0}", message.Email);
        }
    }
}
