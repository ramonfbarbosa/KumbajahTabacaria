using Kumbajah.Services.DTO;
using KumbajahTabacaria.Response;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Kumbajah.Services.Interfaces
{
    public interface IProductService
    {
        Task<ValidationResponse<ProductDTO>> CreateAsync(ProductDTO categoryDTO);
        Task<ValidationResponse<ProductDTO>> UpdateAsync(ProductDTO categoryDTO);
        Task DeleteAsync(int id);
        ProductDTO GetById(int id);
        List<ProductDTO> GetAllProducts();
        Task<List<ProductDTO>> SearchByProductName(string name);
        Task<List<ProductDTO>> SearchByCategoryName(string categoryName);
        Task<List<ProductDTO>> SearchByBrand(string brandName);
    }
}
