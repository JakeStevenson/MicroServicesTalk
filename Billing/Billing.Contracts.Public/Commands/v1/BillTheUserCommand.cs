using NServiceBus;

namespace Billing.Contracts.Public.Commands.v1
{
    public interface IBillTheUserCommand : ICommand
    {
        string Email { get; set; }
        string CCNumber { get; set; }
    }
}
