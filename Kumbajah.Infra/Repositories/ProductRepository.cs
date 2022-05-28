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
        private KumbajahContext Context { get; }

        public ProductRepository(KumbajahContext context) : base(context)
        {
            Context = context;
        }

        public async Task<Product> GetByProductName(string name)
        {
            var user = await Context.Product
                .Where(x => x.Name.ToLower() == name.ToLower())
                .AsNoTracking()
                .ToListAsync();

            return user.FirstOrDefault();
        }

        public async Task<List<Product>> SearchByCategory(Category category)
        {
            var productsByCategory = await Context.Product
               .Where(x => x.Name.ToLower().Contains(category.Name.ToLower()))
               .AsNoTracking()
               .ToListAsync();

            return productsByCategory;
        }

        public async Task<List<Product>> SearchByProductName(string name)
        {
            var allProducts = await Context.Product
               .Where(x => x.Name.ToLower().Contains(name.ToLower()))
               .AsNoTracking()
               .ToListAsync();

            return allProducts;
        }

        public async Task<List<Product>> SearchByBrand(string brandName)
        {
            var productsByBrand = await Context.Product
                .Where(x => x.Brand.ToLower().Contains(brandName.ToLower()))
                .AsNoTracking()
                .ToListAsync();

            return productsByBrand;
        }

        public new virtual async Task<Product> Create(Product obj)
        {
            obj.CreatedTime = DateTime.Now;
            Context.Add(obj);
            await Context.SaveChangesAsync();

            return obj;
        }

        public async Task<List<Product>> SearchByCategoryName(string categoryName)
        {
            var productsByCatgegoryName = await Context.Product
                .Where(x => x.Category.Name.ToLower().Contains(categoryName.ToLower()))
                .AsNoTracking()
                .ToListAsync();

            return productsByCatgegoryName;
        }
    }
}
