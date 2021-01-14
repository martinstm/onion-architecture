using Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApiClient.Abstractions
{
    public interface IUserClient
    {
        Task<IEnumerable<User>> GetAll();
        Task<User> GetById(int id);
    }
}
