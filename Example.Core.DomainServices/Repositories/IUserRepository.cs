using Models;

namespace Example.Core.DomainServices.Repositories
{
    public interface IUserRepository
    {
        User FindById(int id);
    }
}
