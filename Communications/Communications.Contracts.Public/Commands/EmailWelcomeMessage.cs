using NServiceBus;

namespace Communications.Contracts.Public.Commands
{
    public class EmailWelcomeMessage : ICommand
    {
        public string Email { get; set; }
        public string Name { get; set; }
    }

}
