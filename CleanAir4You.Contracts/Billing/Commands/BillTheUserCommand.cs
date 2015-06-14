namespace CleanAir4You.Contracts.Billing.Commands
{
    public class BillTheUserCommand : ICommand
    {
        public string Email { get; set; }
        public string CCNumber { get; set; }
    }
}
