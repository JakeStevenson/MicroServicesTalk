using NServiceBus;

namespace Billing.Contracts.Public
{
    public class BillTheUserCommand : ICommand
    {
        public string Email { get; set; }
        public string CCNumber { get; set; }
    }
}
