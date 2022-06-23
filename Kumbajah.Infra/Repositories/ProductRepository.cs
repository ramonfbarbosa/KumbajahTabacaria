using Kumbajah.Domain.Entities;
using Kumbajah.Infra.Context;
using Kumbajah.Infra.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kumbajah.Infra.Repositories
{
    public class ProductRepository : BaseRepository<Product>, IProductRepository
    {
        private new KumbajahContext Context { get; }

        public ProductRepository(KumbajahContext context) : base(context)
        {
            Context = context;
        }

        public async Task<Product> GetByProductName(string name)
        {
            var productName = await Context.Products
                .Where(x => x.Name.ToLower() == name.ToLower())
                .AsNoTracking()
                .ToListAsync();

            return productName.FirstOrDefault();
        }

        public async Task<List<Product>> SearchByCategoryName(Category category)
        {
            var productsByCategory = await Context.Products
               .Where(x => x.Category.Name.ToLower().Contains(category.Name.ToLower()))
               .AsNoTracking()
               .ToListAsync();

            return productsByCategory;
        }

        public async Task<List<Product>> SearchByProductName(string name)
        {
            var allProducts = await Context.Products
               .Where(x => x.Name.ToLower().Contains(name.ToLower()))
               .AsNoTracking()
               .ToListAsync();

            return allProducts;
        }

        public async Task<List<Product>> SearchByBrandName(string brandName)
        {
            var productsByBrandname = await Context.Products
                .Where(x => x.Brand.Name.ToLower().Contains(brandName.ToLower()))
                .AsNoTracking()
                .ToListAsync();

            return productsByBrandname;
        }

        public async Task<List<Product>> SearchByCategoryName(string categoryName)
        {
            var productsByCatgegoryName = await Context.Products
                .Where(x => x.Category.Name.ToLower().Contains(categoryName.ToLower()))
                .AsNoTracking()
                .ToListAsync();

            return productsByCatgegoryName;
        }

        public async Task<List<Product>> SearchProductByColorName(string colorName)
        {
            var productsByColorName = await Context.Products
               .Where(x => x.Color.ColorName.ToLower().Contains(colorName.ToLower()))
               .AsNoTracking()
               .ToListAsync();

            return productsByColorName;
        }
    }
}
