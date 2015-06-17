using NServiceBus;
namespace AccountManagement.Contracts.Public.Commands.v1
{
    public interface ISignupUserCommand : ICommand
    {
        string Email { get; set; }
        string Name { get; set; }
        string Password { get; set; }
    }
}