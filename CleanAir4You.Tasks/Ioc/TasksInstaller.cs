using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using CleanAir4You.Contracts;

namespace CleanAir4You.Tasks.Ioc
{
    public class TasksInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Classes.FromThisAssembly().BasedOn(typeof(IHandle<>)).WithService.AllInterfaces().LifestyleTransient());
            container.Register(Classes.FromThisAssembly().BasedOn(typeof(ISubscribe<>)).WithService.AllInterfaces().LifestyleTransient());
        }
    }
}
