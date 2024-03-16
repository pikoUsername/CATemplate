using Microsoft.OpenApi.Any;

namespace NameApp.Infrastructure.EventDispatcher
{
    public interface IEventDispatcher
    {
        public void RegisterEventSubscriber<TEventSubscriber>(TEventSubscriber eventSubscriber)
            where TEventSubscriber : IEventSubscriber<IEvent>;
        public void AddListener<TEvent>(Action<TEvent> listener) where TEvent : IEvent;
        public void RemoveListener<TEvent>(Action<TEvent> listener) where TEvent : IEvent;
        public void Dispatch<TEvent>(TEvent @event) where TEvent : IEvent;
    }
}
