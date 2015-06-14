using System.Web.Mvc;
using CleanAir4You.Bus;
using CleanAir4You.com.Areas.AccountManagement.Models;
using CleanAir4You.Contracts.Billing.Commands;

namespace CleanAir4You.com.Areas.Billing.Controllers
{
    public class BillingController : Controller
    {
        private readonly IBus bus;

        public BillingController(IBus bus)
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
            bus.Send(new BillTheUserCommand(){Email = model.Email, CCNumber = model.CCNumber});
            return View("Success", model);
        }
    }
}