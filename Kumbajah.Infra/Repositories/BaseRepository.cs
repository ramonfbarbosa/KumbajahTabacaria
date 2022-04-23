using Kumbajah.Domain.Entities;
using Kumbajah.Infra.Context;
using Kumbajah.Infra.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kumbajah.Infra.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : Base
    {
        public readonly KumbajahContext _context;

        public BaseRepository(KumbajahContext context)
        {
            _context = context;
        }

        public virtual async Task<T> GetById(long id)
        {
            var obj = await _context.Set<T>()
                                    .AsNoTracking()
                                    .Where(x => x.Id == id)
                                    .ToListAsync();
            return obj.FirstOrDefault();
        }

        public virtual async Task<List<T>> Get()
        {
            return await _context.Set<T>()
                                 .AsNoTracking()
                                 .ToListAsync();
        }

        public virtual async Task<T> Create(T obj, DateTime? createdTime)
        {
            createdTime ??= DateTime.Now;
            obj.CreatedTime = createdTime;

            _context.Add(obj);
            await _context.SaveChangesAsync();

            return obj;
        }

        public virtual async Task<T> Update(T obj, DateTime? updateTime)
        {
            updateTime ??= DateTime.Now;
            obj.UpdateTime = updateTime;

            _context.Entry(obj).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return obj;
        }

        public virtual async Task Delete(long id)
        {
            var obj = await GetById(id);

            if (obj != null)
            {
                _context.Remove(obj);
                await _context.SaveChangesAsync();
            }
        }
    }
}
