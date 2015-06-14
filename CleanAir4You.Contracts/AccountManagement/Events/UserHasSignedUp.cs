namespace CleanAir4You.Contracts.AccountManagement.Events
{
    public class UserHasSignedUp : IEvent
    {
        public string Email { get; set; }
        public string Name { get; set; }
    }
}