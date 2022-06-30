using Kumbajah.Domain.Entities;
using Kumbajah.Infra.Context;
using Kumbajah.Infra.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kumbajah.Infra.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private KumbajahContext KumbajahContext { get; }

        public ProductRepository(KumbajahContext kumbajaCcontext)
        {
            KumbajahContext = kumbajaCcontext;
        }

        public Product GetById(int id) =>
            KumbajahContext.Products.AsNoTracking()
                .FirstOrDefault(x => x.Id == id);

        public List<Product> GetAll() =>
            KumbajahContext.Products.ToList();

        public Product GetByProductName(string name) =>
            KumbajahContext.Products
                .FirstOrDefault(x => x.Name.ToLower() == name.ToLower());

        public async Task<List<Product>> SearchByCategoryName(Category category)
        {
            var productsByCategory = await KumbajahContext.Products
               .Where(x => x.Category.Name.ToLower()
               .Contains(category.Name.ToLower()))
               .AsNoTracking()
               .ToListAsync();

            return productsByCategory;
        }

        public async Task<List<Product>> SearchByProductName(string name)
        {
            var allProducts = await KumbajahContext.Products
               .Where(x => x.Name.ToLower()
               .Contains(name.ToLower()))
               .AsNoTracking()
               .ToListAsync();

            return allProducts;
        }

        public async Task<List<Product>> SearchByBrandName(string brandName)
        {
            var productsByBrandname = await KumbajahContext.Products
                .Where(x => x.Brand.Name.ToLower()
                .Contains(brandName.ToLower()))
                .AsNoTracking()
                .ToListAsync();

            return productsByBrandname;
        }

        public async Task<List<Product>> SearchByCategoryName(string categoryName)
        {
            var productsByCatgegoryName = await KumbajahContext.Products
                .Where(x => x.Category.Name.ToLower().Contains(categoryName.ToLower()))
                .AsNoTracking()
                .ToListAsync();

            return productsByCatgegoryName;
        }

        public async Task<List<Product>> SearchProductByColorName(string colorName)
        {
            var productsByColorName = await KumbajahContext.Products
               .Where(x => x.Color.ColorName.ToLower().Contains(colorName.ToLower()))
               .AsNoTracking()
               .ToListAsync();

            return productsByColorName;
        }

        public async Task<Product> CreateAsync(Product newProduct)
        {
            KumbajahContext.Add(newProduct);
            await KumbajahContext.SaveChangesAsync();
            return newProduct;
        }

        public async Task<Product> UpdateAsync(Product updatedProduct)
        {
            var proxy = KumbajahContext.Attach(updatedProduct);
            proxy.State = EntityState.Modified;
            KumbajahContext.Update(updatedProduct);
            await KumbajahContext.SaveChangesAsync();
            return proxy.Entity;
        }

        public async Task DeleteAsync(int id)
        {
            var product = GetById(id);
            if (product != null)
            {
                KumbajahContext.Remove(product);
                await KumbajahContext.SaveChangesAsync();
            }
        }
    }
}
