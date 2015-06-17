using System;
using Communications.Contracts.Public.Commands.v1;
using NServiceBus;

namespace Communications.Tasks.CommandHandlers
{
    public class SendWelcomeMessageHandler : IHandleMessages<IEmailWelcomeMessage>
    {
        public void Handle(IEmailWelcomeMessage message)
        {
            //SEND AN EMAIL 
            Console.WriteLine("Sending a welcome email to {0}", message.Email);
        }
    }
}
