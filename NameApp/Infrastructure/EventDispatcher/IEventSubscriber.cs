namespace NameApp.Infrastructure.EventDispatcher
{
    public interface IEventSubscriber<TEvent> where TEvent : IEvent
    {
        void HandleEvent(TEvent @event);
    }
}
