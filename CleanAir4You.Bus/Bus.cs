using System;
using System.Linq;
using Castle.Core;
using Castle.Core.Internal;
using CleanAir4You.Contracts;
using Microsoft.Practices.ServiceLocation;

namespace CleanAir4You.Bus
{
    public interface IBus
    {
        void Send<TCommand>(TCommand command) where TCommand : ICommand;
        void Publish<TEvent>(TEvent busEvent) where TEvent : IEvent;
    }

    public class Bus : IBus
    {
        public void Send<TCommand>(TCommand command) where TCommand : ICommand
        {
            var handlers = ServiceLocator.Current.GetAllInstances<IHandle<TCommand>>().ToArray();
            if (handlers == null || !handlers.Any()) { throw new NotImplementedException("Unable to find handler for this command");}
            handlers.First().Handle(command);
        }

        public void Publish<TEvent>(TEvent busEvent) where TEvent : IEvent
        {
            var handlers = ServiceLocator.Current.GetAllInstances<ISubscribe<TEvent>>();
            handlers.ForEach(h => h.Handle(busEvent));
        }
    }
}
