namespace CleanAir4You.Contracts.Comunications.Commands
{
    public class SendBillingMessage : ICommand
    {
        public string Email { get; set; }
    }
}