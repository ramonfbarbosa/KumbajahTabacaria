using Kumbajah.Domain.Entities;
using Kumbajah.Infra.Context;
using Kumbajah.Infra.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kumbajah.Infra.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : Base
    {
        public KumbajahContext Context { get; }

        public BaseRepository(KumbajahContext context)
        {
            Context = context;
        }

        public virtual async Task<T> GetById(long id)
        {
            var obj = await Context.Set<T>()
                                    .AsNoTracking()
                                    .Where(x => x.Id == id)
                                    .ToListAsync();
            return obj.FirstOrDefault();
        }

        public virtual async Task<List<T>> Get()
        {
            return await Context.Set<T>()
                                 .AsNoTracking()
                                 .ToListAsync();
        }

        public virtual async Task<T> Create(T obj)
        {
            Context.Add(obj);
            await Context.SaveChangesAsync();

            return obj;
        }

        public virtual async Task<T> Update(T obj)
        {
            Context.Entry(obj).State = EntityState.Modified;
            await Context.SaveChangesAsync();

            return obj;
        }

        public virtual async Task Delete(long id)
        {
            var obj = await GetById(id);

            if (obj != null)
            {
                Context.Remove(obj);
                await Context.SaveChangesAsync();
            }
        }
    }
}
