using System.Web.Mvc;
using Billing.Contracts.Public;
using Billing.Contracts.Public.Commands.v1;
using CleanAir4You.com.Areas.AccountManagement.Models;
using NServiceBus;

namespace CleanAir4You.com.Areas.Billing.Controllers
{
    public class BillingController : Controller
    {
        private readonly ISendOnlyBus bus;

        public BillingController(ISendOnlyBus bus)
        {
            this.bus = bus;
        }

        [HttpGet]
        public ActionResult Index(string email)
        {
            return View(new BillingViewModel(){Email = email});
        }

        [HttpPost]
        public ActionResult Index(BillingViewModel model)
        {
            bus.Send<IBillTheUserCommand>((x) =>
            {
                x.Email = model.Email;
                x.CCNumber = model.CCNumber;
            });
            return View("Success", model);
        }
    }
}