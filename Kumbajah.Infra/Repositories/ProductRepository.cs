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
    public class ProductRepository : BaseRepository<Product>, IProductRepository
    {
        private new readonly KumbajahContext _context;

        public ProductRepository(KumbajahContext context) : base(context)
        {
            _context = context;
        }

        public async Task<Product> GetByProductName(string name)
        {
            var user = await _context.Product
                .Where(x => x.Name.ToLower() == name.ToLower())
                .AsNoTracking()
                .ToListAsync();

            return user.FirstOrDefault();
        }

        public async Task<List<Product>> SearchByCategory(Category category)
        {
            var productsByCategory = await _context.Product
               .Where(x => x.Name.ToLower().Contains(category.Name.ToLower()))
               .AsNoTracking()
               .ToListAsync();

            return productsByCategory;
        }

        public async Task<List<Product>> SearchByProductName(string name)
        {
            var allProducts = await _context.Product
               .Where(x => x.Name.ToLower().Contains(name.ToLower()))
               .AsNoTracking()
               .ToListAsync();

            return allProducts;
        }

        public virtual async Task<Product> Create(Product obj)
        {
            obj.CreatedTime = DateTime.Now;
            _context.Add(obj);
            await _context.SaveChangesAsync();

            return obj;
        }
    }
}
