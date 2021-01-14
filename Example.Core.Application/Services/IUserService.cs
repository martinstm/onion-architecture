using Models;

namespace Example.Core.Application.Services
{
    public interface IUserService
    {
        User GetById(int id);
    }
}
