using System.Diagnostics;
using System.Web.Mvc;
using Billing.UI.Models;

namespace Billing.UI.Controllers
{
    public class CollectBillingController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(BillingViewModel model)
        {
            Response.AppendHeader("Access-Control-Allow-Origin", "*");
            return new EmptyResult();
        }
    }
}