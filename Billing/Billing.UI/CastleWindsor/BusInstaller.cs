﻿using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using Newtonsoft.Json;
using NServiceBus;

namespace CleanAir4You.com.CastleWindsor
{
    public class BusInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Component.For<ISendOnlyBus>().UsingFactoryMethod((kernel, componentModel) =>
            {
                var configuration = new BusConfiguration();
                configuration.EndpointName("CleanAir.UI");
                configuration.EnableInstallers();
                configuration.Transactions().DisableDistributedTransactions();
                configuration.UseSerialization<NServiceBus.JsonSerializer>();

                configuration.UseTransport<RabbitMQTransport>();
                configuration.UsePersistence<InMemoryPersistence>();
                configuration.AssembliesToScan(AllAssemblies.Except("ClearScript"));
                return Bus.CreateSendOnly(configuration);
            }));
        }
    }
}