using Kumbajah.Services.DTO;
using Kumbajah.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Kumbajah.Services.Services
{
    public class CategoryService : ICategoryService
    {
        public Task<UserDTO> Create(CategoryDTO categoryDTO)
        {
            throw new NotImplementedException();
        }

        public Task<List<CategoryDTO>> GetAllCategories()
        {
            throw new NotImplementedException();
        }

        public Task<CategoryDTO> GetByCategoryName(string name)
        {
            throw new NotImplementedException();
        }

        public Task<CategoryDTO> GetByEmail(string email)
        {
            throw new NotImplementedException();
        }

        public Task<CategoryDTO> GetById(long id)
        {
            throw new NotImplementedException();
        }

        public Task Remove(long id)
        {
            throw new NotImplementedException();
        }

        public Task<List<CategoryDTO>> SearchByCategoryName(string name)
        {
            throw new NotImplementedException();
        }

        public Task<List<CategoryDTO>> SearchByEmail(string email)
        {
            throw new NotImplementedException();
        }

        public Task<List<CategoryDTO>> SearchByName(string name)
        {
            throw new NotImplementedException();
        }

        public Task<UserDTO> Update(CategoryDTO categoryDTO)
        {
            throw new NotImplementedException();
        }
    }
}
