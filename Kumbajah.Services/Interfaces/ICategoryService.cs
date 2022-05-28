using Kumbajah.Services.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Kumbajah.Services.Interfaces
{
    public interface ICategoryService
    {
        Task<CategoryDTO> Create(CategoryDTO categoryDTO);
        Task<CategoryDTO> Update(CategoryDTO categoryDTO);
        Task Remove(long id);
        Task<CategoryDTO> GetById(long id);
        Task<List<CategoryDTO>> GetAllCategories();
    }
}
