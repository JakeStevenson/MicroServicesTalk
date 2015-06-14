using CleanAir4You.com.Areas.AccountManagement.DTOs;

namespace CleanAir4You.com.Areas.AccountManagement.Services
{
    public class SignupService
    {
        public bool SignupUser(UserDto user)
        {
            //STORE THE USER
            System.Diagnostics.Debug.WriteLine("Saving user {0}", user.Email);
            return true;
        }
    }
}