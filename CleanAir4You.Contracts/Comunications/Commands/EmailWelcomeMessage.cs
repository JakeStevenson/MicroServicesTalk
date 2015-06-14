namespace CleanAir4You.Contracts.Comunications.Commands
{
    public class EmailWelcomeMessage : ICommand
    {
        public string Email { get; set; }
        public string Name { get; set; }
    }
}
