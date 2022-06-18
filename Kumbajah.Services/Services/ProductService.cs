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
    public class ProductService : IProductService
    {
        private IMapper Mapper { get; }
        private ProductRepository ProductRepository { get; }

        public async Task<ProductDTO> Create(ProductDTO productDTO)
        {
            var product = Mapper.Map<Product>(productDTO);
            var createdProduct = await ProductRepository.Create(product);
            return Mapper.Map<ProductDTO>(createdProduct);
        }

        public async Task<ProductDTO> Update(ProductDTO productDTO)
        {
            var existingProduct = await ProductRepository.GetById(productDTO.Id);
            if (existingProduct != null)
                throw new DomainException("Não existe nenhum produto com este Id");
            var product = Mapper.Map<Product>(existingProduct);
            var updatedProduct = await ProductRepository.Update(product);
            return Mapper.Map<ProductDTO>(updatedProduct);
        }

        public async Task Remove(long id)
        {
            await ProductRepository.Delete(id);
        }

        public async Task<List<ProductDTO>> GetAllProducts()
        {
            var allProducts = await ProductRepository.Get();
            return Mapper.Map<List<ProductDTO>>(allProducts);
        }

        public async Task<ProductDTO> GetById(long id)
        {
            var product = await ProductRepository.GetById(id);
            return Mapper.Map<ProductDTO>(product);
        }

        public async Task<List<ProductDTO>> SearchByBrand(string brandName)
        {
            var allBrands = await ProductRepository.SearchByBrandName(brandName);
            return Mapper.Map<List<ProductDTO>>(allBrands);
        }

        public async Task<List<ProductDTO>> SearchByCategoryName(string categoryName)
        {
            var allCategoriesName = await ProductRepository.SearchByCategoryName(categoryName);
            return Mapper.Map<List<ProductDTO>>(allCategoriesName);
        }

        public async Task<List<ProductDTO>> SearchByProductName(string productName)
        {
            var allProductsName = await ProductRepository.SearchByProductName(productName);
            return Mapper.Map<List<ProductDTO>>(allProductsName);
        }
    }
}
