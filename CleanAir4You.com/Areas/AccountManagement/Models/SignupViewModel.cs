namespace CleanAir4You.com.Areas.AccountManagement.Models
{
    public class SignupViewModel
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }

    public class BillingViewModel
    {
        public string Email { get; set; }
        public string CCNumber { get; set; }
    }
}