using NServiceBus;

namespace Communications.Contracts.Public.Commands.v1
{
    public interface ISendBillingMessage : ICommand
    {
        string Email { get; set; }
    }
}
