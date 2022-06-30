using Kumbajah.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Kumbajah.Infra.Interfaces
{
    public interface IProductRepository
    {
        Product GetById(int id);
        List<Product> GetAll();
        Product GetByProductName(string name);
        Task<List<Product>> SearchByProductName(string name);
        Task<List<Product>> SearchByCategoryName(string categoryName);
        Task<List<Product>> SearchByBrandName(string brandName);
        Task<List<Product>> SearchProductByColorName(string colorName);
        Task<Product> CreateAsync(Product newProduct);
        Task<Product> UpdateAsync(Product updatedProduct);
        Task DeleteAsync(int id);
    }
}
