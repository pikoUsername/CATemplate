using NameApp.Application.Common.IoC;
using NameApp.Application.User;
using NameApp.Application.User.Interfaces;

namespace NameApp.Application
{
    public class IoContainer : IIoContainer
    {
        public IoContainer() { }

        public IUserService User()
        {
            return new UserService();
        }
    }
}
