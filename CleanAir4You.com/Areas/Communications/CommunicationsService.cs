using System.Diagnostics;

namespace CleanAir4You.com.Areas.Communications
{
    public class CommunicationsService
    {
        public void EmailWelcomeMessage(string email)
        {
            Debug.WriteLine(string.Format("Emailing welcome to {0}", email));
        }

        public void EmailBillingMessage(string email)
        {
            Debug.WriteLine(string.Format("Emailing billing to {0}", email));
        }
    }
}