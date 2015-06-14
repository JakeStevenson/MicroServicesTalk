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
            return RedirectToAction("Index", "Billing", new {area = "Billing"});
        }

    }
}