using NServiceBus;

namespace Communications.Contracts.Public.Commands
{
    public class SendBillingMessage : ICommand
    {
        public string Email { get; set; }
    }
}
