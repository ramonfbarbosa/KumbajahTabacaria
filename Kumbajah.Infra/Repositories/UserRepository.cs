﻿using Kumbajah.Domain.Entities;
using Kumbajah.Infra.Context;
using Kumbajah.Infra.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kumbajah.Infra.Repositories
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        private KumbajahContext Context { get; }

        public UserRepository(KumbajahContext context) : base(context)
        {
            Context = context;
        }

        public async Task<User> GetByEmail(string email)
        {
            var user = await Context.User
                .Where(x => x.Email.ToLower().Equals(email.ToLower()))
                .AsNoTracking()
                .ToListAsync();

            return user.FirstOrDefault();
        }

        public async Task<User> GetByCPF(long cpf)
        {
            var user = await Context.User
                .Where(x => x.CPF.Equals(cpf))
                .AsNoTracking()
                .ToListAsync();

            return user.FirstOrDefault();
        }

        public async Task<List<User>> SearchByEmail(string email)
        {
            var allUsers = await Context.User
                .Where(x => x.Email.ToLower().Contains(email.ToLower()))
                .AsNoTracking()
                .ToListAsync();

            return allUsers;
        }

        public async Task<List<User>> SearchByName(string name)
        {
            var allUsers = await Context.User
                .Where(x => x.Name.ToLower().Contains(name.ToLower()))
                .AsNoTracking()
                .ToListAsync();

            return allUsers;
        }
    }
}
