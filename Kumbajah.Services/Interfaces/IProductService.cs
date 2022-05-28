using Kumbajah.Services.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Kumbajah.Services.Interfaces
{
    public interface IProductService
    {
        Task<ProductDTO> Create(ProductDTO categoryDTO);
        Task<ProductDTO> Update(ProductDTO categoryDTO);
        Task Remove(long id);
        Task<ProductDTO> GetById(long id);
        Task<List<ProductDTO>> GetAllProducts();
        Task<List<ProductDTO>> SearchByProductName(string name);
        Task<List<ProductDTO>> SearchByCategoryName(string categoryName);
        Task<List<ProductDTO>> SearchByBrand(string brandName);
    }
}
