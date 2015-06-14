namespace CleanAir4You.Contracts.Billing.Events
{
    public class UserWasBilledEvent : IEvent
    {
        public string Email { get; set; }
    }
}
