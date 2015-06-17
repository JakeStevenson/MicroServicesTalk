using System;
using Communications.Contracts.Public.Commands.v1;
using NServiceBus;

namespace Communications.Tasks.CommandHandlers
{
    public class SendBillingMessageCommandHandler : IHandleMessages<ISendBillingMessage>
    {
        public void Handle(ISendBillingMessage message)
        {
            Console.WriteLine("Sending a billing email to {0}", message.Email);
        }
    }

}
