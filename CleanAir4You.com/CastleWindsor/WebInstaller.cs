using System.Web.Mvc;
using Castle.Core;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using Castle.Windsor.Mvc;

namespace CleanAir4You.com.CastleWindsor
{
    public class WebInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            ControllerBuilder.Current.SetControllerFactory(new WindsorControllerFactory(container.Kernel));

            container.Register(Classes.FromThisAssembly().BasedOn<IController>().LifestylePerWebRequest());
        }
    }
}