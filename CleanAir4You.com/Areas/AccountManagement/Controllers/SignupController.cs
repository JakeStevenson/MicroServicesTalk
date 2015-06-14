using System.Web.Mvc;
using CleanAir4You.com.Areas.AccountManagement.Models;

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
            return RedirectToAction("Bill");
        }


        [HttpGet]
        public ActionResult Bill()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Bill(BillingViewModel model)
        {
            return View("Success", model);
        }
    }
}