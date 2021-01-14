using Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApiClient.Abstractions
{
    public interface IGroupClient
    {
        Task<IEnumerable<Group>> GetAll();
        Task<Group> GetById(int id);
    }
}
