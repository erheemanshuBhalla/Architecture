using Architecture_V4.Core.Entities;

namespace Architecture_V4.Core.Interfaces
{
    public interface IUserRepository : IRepository<User>
    {
        /* Respoir*/
        Task<User?> GetByEmailAsync(string email);
    }

}
