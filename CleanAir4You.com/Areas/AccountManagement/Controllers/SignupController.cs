using System.Web.Mvc;
using CleanAir4You.com.Areas.AccountManagement.DTOs;
using CleanAir4You.com.Areas.AccountManagement.Models;
using CleanAir4You.com.Areas.AccountManagement.Services;
using CleanAir4You.com.Areas.Communications;

namespace CleanAir4You.com.Areas.AccountManagement.Controllers
{
    public class SignupController : Controller
    {
        // GET: AccountManagement/Signup
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(SignupViewModel model)
        {
            //Create the User
            var signup = new SignupService();
            if(!signup.SignupUser(new UserDto(){Email = model.Email, Password = model.Password, Name = model.Name}))
            {
                RedirectToAction("Index");
            }
            
            var email = new CommunicationsService();
            email.EmailWelcomeMessage(model.Email);
            return RedirectToAction("Index", "Billing", new {area = "Billing", email = model.Email});
        }

    }
}