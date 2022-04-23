﻿using Kumbajah.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Kumbajah.Infra.Interfaces
{
    public interface IProductRepository
    {
        Task<Product> GetByProductName(string name);
        Task<List<Product>> SearchByProductName(string name);
        Task<List<Product>> SearchByCategory(Category category);
    }
}
