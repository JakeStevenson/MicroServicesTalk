using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Castle.Windsor;
using CleanAir4You.Bus.Ioc;
using CleanAir4You.com.Areas.AccountManagement.Controllers;
using CleanAir4You.com.CastleWindsor;
using CleanAir4You.Tasks.Ioc;
using CommonServiceLocator.WindsorAdapter;
using Microsoft.Practices.ServiceLocation;

namespace CleanAir4You.com
{
    public class MvcApplication : HttpApplication
    {
        protected void Application_Start()
        {
            var container = new WindsorContainer();
            container.Install(new WebInstaller());
            container.Install(new BusInstaller());
            container.Install(new TasksInstaller());

            ServiceLocator.SetLocatorProvider(() => new WindsorServiceLocator(container));

            //var controller = container.Resolve<SignupController>();

            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
