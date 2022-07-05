using Kumbajah.Domain.Entities;
using Kumbajah.Infra.Pagination;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kumbajah.Infra.Interfaces
{
    public interface IProductRepository
    {
        Product GetById(int id);
        Product GetByName(string name);
        List<Product> GetAll();
        IQueryable<Product> Filter(Filter filter);
        IQueryable<Product> OrderBy(IQueryable<Product> products, List<SortingPage> sortings);
        Task<Product> CreateAsync(Product newProduct);
        Task<Product> UpdateAsync(Product updatedProduct);
        Task<string> DeleteAsync(int id);
    }
}
