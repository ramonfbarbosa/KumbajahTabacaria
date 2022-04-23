using Kumbajah.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Kumbajah.Infra.Interfaces
{
    public interface IBaseRepository<T> where T : Base
    {
        Task<T> GetById(long id);
        Task<List<T>> Get();
        Task<T> Create(T obj, DateTime? createdTime);
        Task<T> Update(T obj, DateTime? updateTime);
        Task Delete(long id);
    }
}
