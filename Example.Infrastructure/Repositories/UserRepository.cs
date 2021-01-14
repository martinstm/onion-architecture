using Example.Core.Domain;
using Example.Core.DomainServices.Repositories;
using Models;
using System.Collections.Generic;
using System.Linq;

namespace Example.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private List<UserEntity> _inMemoryUsers;

        public UserRepository()
        {
            _inMemoryUsers = new List<UserEntity>()
            {
                new UserEntity { Id = 1, Name = "John Snow", Email = "snow@mail.com", Active = true},
                new UserEntity { Id = 2, Name = "James Bond", Email = "bond@mail.com", Active = true },
            };
        }

        public User FindById(int id)
        {
            return MapUser(_inMemoryUsers.SingleOrDefault(s => s.Id == id));
        }

        private User MapUser(UserEntity userEntity)
        {
            if (userEntity == null)
                return null;
            return new User(userEntity.Id, userEntity.Name, userEntity.Email, userEntity.Active);
        }
    }
}
