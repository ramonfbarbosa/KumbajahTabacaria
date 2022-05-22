﻿using Kumbajah.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Kumbajah.Infra.Interfaces
{
    public interface IBaseRepository<T> where T : Base
    {
        Task<T> GetById(long id);
        Task<List<T>> Get();
        Task<T> Create(T obj);
        Task<T> Update(T obj);
        Task Delete(long id);
    }
}
