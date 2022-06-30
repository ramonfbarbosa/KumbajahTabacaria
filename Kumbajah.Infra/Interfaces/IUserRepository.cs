using Kumbajah.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Kumbajah.Infra.Interfaces
{
    public interface IUserRepository
    {
        User GetById(int id);
        List<User> GetAll();
        User GetByEmail(string email);
        User GetByCPF(string cpf);
        Task<List<User>> SearchByName(string name);
        Task<User> ChangeEmail(string email);
        Task<User> ChangePhoneNumber(string phoneNumber);
        Task<User> ChangePassword(string password);
        Task<User> CreateAsync(User newUser);
        Task<User> UpdateAsync(User updatedUser);
    }
}
