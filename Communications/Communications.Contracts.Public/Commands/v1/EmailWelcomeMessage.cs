using NServiceBus;

namespace Communications.Contracts.Public.Commands.v1
{
    public interface IEmailWelcomeMessage : ICommand
    {
        string Email { get; set; }
        string Name { get; set; }
    }

}
