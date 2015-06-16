using System.Diagnostics;
using Communications.Contracts.Public.Commands;
using NServiceBus;

namespace Communications.Tasks.CommandHandlers
{
    public class SendBillingMessageCommandHandler : IHandleMessages<SendBillingMessage>
    {
        public void Handle(SendBillingMessage message)
        {
            Debug.WriteLine("Sending a billing email to {0}", message.Email);
        }
    }

}
