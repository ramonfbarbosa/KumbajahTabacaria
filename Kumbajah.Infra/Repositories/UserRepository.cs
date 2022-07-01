using Kumbajah.Domain.Entities;
using Kumbajah.Infra.Context;
using Kumbajah.Infra.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kumbajah.Infra.Repositories
{
    public class UserRepository : IUserRepository
    {
        private KumbajahContext KumbajahContext { get; }

        public UserRepository(KumbajahContext kumbajahContext)
        {
            KumbajahContext = kumbajahContext;
        }

        public User GetById(int id) =>
            KumbajahContext.Users.AsNoTracking()
                .FirstOrDefault(x => x.Id == id);

        public List<User> GetAll() =>
            KumbajahContext.Users.ToList();

        public User GetByEmail(string email) =>
            KumbajahContext.Users
                .FirstOrDefault(x => x.Email.ToLower()
                .Equals(email.ToLower()));

        public User GetByCPF(string cpf) =>
            KumbajahContext.Users
                .FirstOrDefault(x => x.CPF
                .Equals(cpf));

        public async Task<List<User>> SearchByName(string name)
        {
            var allUsers = await KumbajahContext.Users
                .Where(x => x.Name.ToLower().Contains(name.ToLower()))
                .AsNoTracking()
                .ToListAsync();

            return allUsers;
        }

        public async Task ChangePhoneNumber(string updatedPhoneNumber)
        {
            var oldPhoneNumber = KumbajahContext.Users
                .Select(x => x.PhoneNumber)
                .FirstOrDefault();
            if (oldPhoneNumber == null) { return; }
            oldPhoneNumber = updatedPhoneNumber ;
        }

        public async Task<User> CreateAsync(User newUser)
        {
            KumbajahContext.Add(newUser);
            await KumbajahContext.SaveChangesAsync();
            return newUser;
        }

        public async Task<User> UpdateAsync(User updatedUser)
        {
            var proxy = KumbajahContext.Attach(updatedUser);
            proxy.State = EntityState.Modified;
            KumbajahContext.Update(updatedUser);
            await KumbajahContext.SaveChangesAsync();
            return proxy.Entity;
        }
    }
}
