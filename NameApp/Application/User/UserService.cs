using NameApp.Application.User.Interactors;
using NameApp.Application.User.Interfaces;

namespace NameApp.Application.User
{
    public class UserService : IUserService
    {
        public RegisterInteractor RegisterInteractor()
        {
            return new RegisterInteractor() { 
                
            };
        }
    }
}
