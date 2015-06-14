namespace CleanAir4You.Contracts.AccountManagement.Commands
{
    public class SignupUserCommand : ICommand
    {
        public string Email { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
    }
}
