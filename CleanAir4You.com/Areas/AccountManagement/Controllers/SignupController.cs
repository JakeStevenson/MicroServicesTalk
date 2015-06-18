using System.Web.Mvc;
using CleanAir4You.Bus;
using CleanAir4You.com.Areas.AccountManagement.Models;
using CleanAir4You.Contracts.AccountManagement.Commands;

namespace CleanAir4You.com.Areas.AccountManagement.Controllers
{
    public class SignupController : Controller
    {
        private readonly IBus bus;

        public SignupController(IBus bus)
        {
            this.bus = bus;
        }

        // GET: AccountManagement/Signup
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(SignupViewModel model)
        {
            bus.Send(new SignupUserCommand(){Email = model.Email, Name = model.Name, Password = model.Password});
            return RedirectToAction("Index", "Billing", new {area = "Billing", email=model.Email});
        }

    }
}