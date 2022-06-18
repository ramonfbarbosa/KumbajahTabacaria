using Kumbajah.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Kumbajah.Infra.Interfaces
{
    public interface IUserRepository : IBaseRepository<User>
    {
        Task<User> GetByEmail(string email);
        Task<List<User>> SearchByName(string name);
        Task<User> GetByCPF(long cpf);
    }
}
