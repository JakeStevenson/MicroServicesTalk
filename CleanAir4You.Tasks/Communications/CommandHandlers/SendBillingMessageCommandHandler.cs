using System.Diagnostics;
using CleanAir4You.Contracts;
using CleanAir4You.Contracts.Comunications.Commands;

namespace CleanAir4You.Tasks.Communications.CommandHandlers
{
    public class SendBillingMessageCommandHandler : IHandle<SendBillingMessage>
    {
        public void Handle(SendBillingMessage message)
        {
            Debug.WriteLine("Sending a billing email to {0}", message.Email);
        }
    }
}
