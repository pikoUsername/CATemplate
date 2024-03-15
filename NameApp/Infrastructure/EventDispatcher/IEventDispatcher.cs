using Microsoft.OpenApi.Any;

namespace NameApp.Infrastructure.EventDispatcher
{
    public interface IEventDispatcher
    {
        void RegisterEventSubscriber<TEventSubscriber, TEvent>(TEventSubscriber eventSubscriber) 
            where TEventSubscriber : IEventSubscriber<TEvent>
            where TEvent : IEvent;
        void AddListener<TEvent>(Action<TEvent> listener) where TEvent : IEvent;
        void RemoveListener<TEvent>(Action<TEvent> listener) where TEvent : IEvent;
        void Dispatch<TEvent>(TEvent @event) where TEvent : IEvent;
    }
}
