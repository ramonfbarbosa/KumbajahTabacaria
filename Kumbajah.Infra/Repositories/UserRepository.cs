using Kumbajah.Domain.Entities;
using Kumbajah.Infra.Context;
using Kumbajah.Infra.Filters;
using Kumbajah.Infra.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kumbajah.Infra.Repositories
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        private new KumbajahContext Context { get; }

        public UserRepository(KumbajahContext context) : base(context)
        {
            Context = context;
        }
        public async Task<List<User>> Get()
        {
            //var validFilter = new PaginationFilter([FromQuery] PaginationFilter filter);
            //var response = await context.Customer.ToListAsync();
            return await Context.Set<User>()
                                 .AsNoTracking()
                                 .ToListAsync();
        }

        public async Task<User> GetByEmail(string email)
        {
            var user = await Context.Users
                .Where(x => x.Email.ToLower().Equals(email.ToLower()))
                .AsNoTracking()
                .ToListAsync();

            return user.FirstOrDefault();
        }

        public async Task<User> GetByCPF(long cpf)
        {
            var user = await Context.Users
                .Where(x => x.CPF.Equals(cpf))
                .AsNoTracking()
                .ToListAsync();

            return user.FirstOrDefault();
        }

        public async Task<List<User>> SearchByName(string name)
        {
            var allUsers = await Context.Users
                .Where(x => x.Name.ToLower().Contains(name.ToLower()))
                .AsNoTracking()
                .ToListAsync();

            return allUsers;
        }
    }
}
