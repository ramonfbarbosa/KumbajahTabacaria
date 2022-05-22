using Kumbajah.Services.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Kumbajah.Services.Interfaces
{
    public interface ICategoryService
    {
        Task<UserDTO> Create(CategoryDTO categoryDTO);
        Task<UserDTO> Update(CategoryDTO categoryDTO);
        Task Remove(long id);
        Task<CategoryDTO> GetById(long id);
        Task<List<CategoryDTO>> GetAllCategories();
        Task<List<CategoryDTO>> SearchByName(string name);
        Task<List<CategoryDTO>> SearchByEmail(string email);
        Task<CategoryDTO> GetByEmail(string email);
        Task<CategoryDTO> GetByCategoryName(string name);
        Task<List<CategoryDTO>> SearchByCategoryName(string name);
    }
}
