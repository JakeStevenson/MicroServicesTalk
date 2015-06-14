using CleanAir4You.Contracts;
using CleanAir4You.Contracts.Comunications.Commands;

namespace CleanAir4You.Tasks.Communications.CommandHandlers
{
    public class SendWelcomeMessageHandler : IHandle<EmailWelcomeMessage>
    {
        public void Handle(EmailWelcomeMessage message)
        {
            //SEND AN EMAIL 
            //THIS CAN BLOCK A WHILE!
            System.Diagnostics.Debug.WriteLine("Sending a welcome email to {0}", message.Email);
        }
    }
}
