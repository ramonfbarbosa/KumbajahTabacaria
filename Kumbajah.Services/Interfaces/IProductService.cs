using Kumbajah.Infra.Pagination;
using Kumbajah.Services.DTO;
using KumbajahTabacaria.Infra.Pagination;
using KumbajahTabacaria.Response;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Kumbajah.Services.Interfaces
{
    public interface IProductService
    {
        ProductDTO GetById(int id);
        List<ProductDTO> GetAll();
        PaginationResponse<ProductDTO> PagedProducts(ListCriteria criteria);
        Task<ValidationResponse<ProductDTO>> CreateAsync(ProductDTO categoryDTO);
        Task<ValidationResponse<ProductDTO>> UpdateAsync(ProductDTO categoryDTO);
        Task<string> DeleteAsync(int id);
    }
}
