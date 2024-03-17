using NameApp.Domain.User.Entities;
using NameApp.Domain.User.Events;
using NameApp.Infrastructure.EventDispatcher;

namespace NameApp.Domain.User.Services
{
    public class UserService
    {
        public IEventDispatcher EventDispatcher { get; set; }

        public UserService(IEventDispatcher eventDispatcher)
        {
            Guard.Against.Null(eventDispatcher, message: "Event dispatcher is not found.");

            EventDispatcher = eventDispatcher; 
        }

        public UserEntity Create()
        {
            var user = new UserEntity();

            EventDispatcher.Dispatch(new UserCreated(User: user));

            return user; 
        }
    }
}
