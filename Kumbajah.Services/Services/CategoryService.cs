using AutoMapper;
using Kumbajah.Core.Exceptions;
using Kumbajah.Domain.Entities;
using Kumbajah.Infra.Repositories;
using Kumbajah.Services.DTO;
using Kumbajah.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Kumbajah.Services.Services
{
    public class CategoryService : ICategoryService
    {
        private IMapper Mapper { get; }
        private CategoryRepository CategoryRepository { get; }

        public async Task<CategoryDTO> Create(CategoryDTO categoryDTO)
        {
            var existingCategory = await CategoryRepository.GetByCategoryName(categoryDTO.Name);
            if (existingCategory != null)
                throw new DomainException("Já existe uma categoria cadastrado com esse nome");
            var category = Mapper.Map<Category>(categoryDTO);
            var createdCategory = await CategoryRepository.Create(category);
            return Mapper.Map<CategoryDTO>(createdCategory);
        }

        public async Task<List<CategoryDTO>> GetAllCategories()
        {
            var allCategories = await CategoryRepository.Get();
            return Mapper.Map<List<CategoryDTO>>(allCategories);
        }

        public async Task<CategoryDTO> GetById(long id)
        {
            var category = await CategoryRepository.GetById(id);
            return Mapper.Map<CategoryDTO>(category);
        }

        public async Task Remove(long id)
        {
            await CategoryRepository.Delete(id);
        }

        public async Task<CategoryDTO> Update(CategoryDTO categoryDTO)
        {
            var existingCategory = await CategoryRepository.GetById(categoryDTO.Id);
            if (existingCategory != null)
                throw new DomainException("Não existe nenhuma categoria com este Id");
            var category = Mapper.Map<Category>(existingCategory);
            var updatedCategory = await CategoryRepository.Update(category);
            return Mapper.Map<CategoryDTO>(updatedCategory);
        }
    }
}
