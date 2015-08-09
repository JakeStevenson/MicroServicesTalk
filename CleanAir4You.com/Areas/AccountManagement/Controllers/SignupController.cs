using System.Web.Mvc;
using AccountManagement.Contracts.Public.Commands.v1;
using CleanAir4You.com.Areas.AccountManagement.Models;
using NServiceBus;

namespace CleanAir4You.com.Areas.AccountManagement.Controllers
{
    public class SignupController : Controller
    {
        private readonly ISendOnlyBus bus;

        public SignupController(ISendOnlyBus bus)
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
            bus.Send<ISignupUserCommand>(x =>
            {
                x.Email = model.Email;
                x.Name = model.Name;
                x.Password = model.Password;
            });
            return Json(new {});
        }

    }
}