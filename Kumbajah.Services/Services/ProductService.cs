using Kumbajah.Services.DTO;
using Kumbajah.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Kumbajah.Services.Services
{
    public class ProductService : IProductService
    {
        public Task<ProductDTO> Create(ProductDTO categoryDTO)
        {
            throw new NotImplementedException();
        }

        public Task<List<ProductDTO>> GetAllProducts()
        {
            throw new NotImplementedException();
        }

        public Task<ProductDTO> GetByEmail(string email)
        {
            throw new NotImplementedException();
        }

        public Task<ProductDTO> GetById(long id)
        {
            throw new NotImplementedException();
        }

        public Task Remove(long id)
        {
            throw new NotImplementedException();
        }

        public Task<List<ProductDTO>> SearchByCategoryName(string categoryName)
        {
            throw new NotImplementedException();
        }

        public Task<List<ProductDTO>> SearchByEmail(string email)
        {
            throw new NotImplementedException();
        }

        public Task<List<ProductDTO>> SearchByName(string name)
        {
            throw new NotImplementedException();
        }

        public Task<ProductDTO> Update(ProductDTO categoryDTO)
        {
            throw new NotImplementedException();
        }
    }
}
