using System.Web.Mvc;
using CleanAir4You.com.Areas.AccountManagement.Models;
using CleanAir4You.com.Areas.Billing.DTOs;
using CleanAir4You.com.Areas.Billing.Services;
using CleanAir4You.com.Areas.Communications;

namespace CleanAir4You.com.Areas.Billing.Controllers
{
    public class BillingController : Controller
    {
        [HttpGet]
        public ActionResult Index(string email)
        {
            return View(new BillingViewModel(){Email = email});
        }

        [HttpPost]
        public ActionResult Index(BillingViewModel model)
        {
            var billingService = new BillingService();
            if (!billingService.ChargeUser(new BillingDto() {CCNumber = model.CCNumber}))
            {
                RedirectToAction("Index");
            }

            var email = new CommunicationsService();
            email.EmailBillingMessage(model.Email);
            return View("Success", model);
        }
    }
}