using NameApp.Application.User.Interfaces;

namespace NameApp.Presentation
{
    public interface IIoContainer
    {
        public IUserService UserService(); 
    }
}
