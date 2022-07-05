using Kumbajah.Domain.Entities;
using Kumbajah.Infra.Context;
using Kumbajah.Infra.Interfaces;
using Kumbajah.Infra.Pagination;
using Microsoft.EntityFrameworkCore;
using System;
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
        public Product GetByName(string name) =>
            KumbajahContext.Products.AsNoTracking()
                .FirstOrDefault(x => x.Name.ToLower() == name.ToLower());

        public List<Product> GetAll() =>
            KumbajahContext.Products.ToList();

        public IQueryable<Product> Filter(Filter filter)
        {
            IQueryable<Product> users = KumbajahContext.Products;
            if (filter == null || filter.Value == null) return users;
            return users.Where(x =>
            x.Id.ToString().Contains(filter.Value.ToLower())
                    || x.Name.Contains(filter.Value.ToLower())
                    || x.Category.Name.Contains(filter.Value.ToLower())
                    || x.Brand.Name.Contains(filter.Value.ToLower())
                    || x.Color.ColorName.Contains(filter.Value.ToLower()));
        }

        public IQueryable<Product> OrderBy(IQueryable<Product> products, List<SortingPage> sortings)
        {
            if (sortings == null || sortings.Count == 0)
            {
                return products;
            }
            var orderedProducts = OrderByFirst(products, sortings.First());
            foreach (var sorting in sortings.Skip(1))
            {
                orderedProducts = NextOrderBy(orderedProducts, sorting);
            }
            return orderedProducts;
        }

        private IOrderedQueryable<Product> OrderByFirst(IQueryable<Product> products, SortingPage sorting) => sorting.Field.ToLower() switch
        {
            "id" => sorting.IsAscending ? products.OrderBy(x => x.Id) : products.OrderByDescending(x => x.Id),
            "email" => sorting.IsAscending ? products.OrderBy(x => x.Name) : products.OrderByDescending(x => x.Name),
            "horadacompra" => sorting.IsAscending ? products.OrderBy(x => x.Category.Name) : products.OrderByDescending(x => x.Category.Name),
            "userid" => sorting.IsAscending ? products.OrderBy(x => x.Brand.Name) : products.OrderByDescending(x => x.Brand.Name),
            "orderstatus" => sorting.IsAscending ? products.OrderBy(x => x.Color.ColorName) : products.OrderByDescending(x => x.Color.ColorName),
            _ => throw new NotImplementedException()
        };

        private IOrderedQueryable<Product> NextOrderBy(IOrderedQueryable<Product> products, SortingPage sorting) => sorting.Field.ToLower() switch
        {
            "id" => sorting.IsAscending ? products.ThenBy(x => x.Id) : products.ThenByDescending(x => x.Id),
            "email" => sorting.IsAscending ? products.ThenBy(x => x.Name) : products.ThenByDescending(x => x.Name),
            "horadacompra" => sorting.IsAscending ? products.ThenBy(x => x.Category.Name) : products.ThenByDescending(x => x.Category.Name),
            "userid" => sorting.IsAscending ? products.ThenBy(x => x.Brand.Name) : products.ThenByDescending(x => x.Brand.Name),
            "orderstatus" => sorting.IsAscending ? products.ThenBy(x => x.Color.ColorName) : products.ThenByDescending(x => x.Color.ColorName),
            _ => throw new NotImplementedException()
        };

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

        public async Task<string> DeleteAsync(int id)
        {
            var product = GetById(id);
            if (product != null)
            {
                KumbajahContext.Remove(product);
                await KumbajahContext.SaveChangesAsync();
                return "Produto removido!";
            }
            return null;
        }
    }
}
