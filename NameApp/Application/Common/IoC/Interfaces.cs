using NameApp.Application.User.Interfaces;

namespace NameApp.Application.Common.IoC
{
    public interface IIoContainer
    {
        public IUserService User();
    }
}
