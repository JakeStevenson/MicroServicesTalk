using System.Web.Mvc;
using CleanAir4You.com.Areas.AccountManagement.Models;

namespace CleanAir4You.com.Areas.Billing.Controllers
{
    public class BillingController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(BillingViewModel model)
        {
            return View("Success", model);
        }
    }
}