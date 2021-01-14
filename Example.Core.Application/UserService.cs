using Example.Core.Application.Services;
using Example.Core.DomainServices.Repositories;
using Models;

namespace Example.Core.Application
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public User GetById(int id)
        {
            return _userRepository.FindById(id);
        }
    }
}
