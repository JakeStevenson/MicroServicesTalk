using CleanAir4You.com.Areas.Billing.DTOs;

namespace CleanAir4You.com.Areas.Billing.Services
{
    public class BillingService
    {
        public bool ChargeUser(BillingDto billingInfo)
        {
            //Charge the user
            System.Diagnostics.Debug.WriteLine(string.Format("Billing user {0}", billingInfo.CCNumber));
            return true;
        }
    }
}