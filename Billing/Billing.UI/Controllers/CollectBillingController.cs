using System.Diagnostics;
using System.Web.Mvc;
using Billing.Contracts.Public.Commands.v1;
using Billing.UI.Models;
using NServiceBus;

namespace Billing.UI.Controllers
{
    public class CollectBillingController : Controller
    {
        private readonly ISendOnlyBus bus;

        public CollectBillingController(ISendOnlyBus bus)
        {
            this.bus = bus;
        }

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(BillingViewModel model)
        {
            Response.AppendHeader("Access-Control-Allow-Origin", "*");
            bus.Send<IBillTheUserCommand>((x) =>
            {
                x.Email = model.Email;
                x.CCNumber = model.CCNumber;
            });
            return Json(new {});

        }
    }
}