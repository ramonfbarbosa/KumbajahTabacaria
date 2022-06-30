using AutoMapper;
using FluentValidation;
using Kumbajah.Domain.Entities;
using Kumbajah.Infra.Interfaces;
using Kumbajah.Services.DTO;
using Kumbajah.Services.Interfaces;
using KumbajahTabacaria.Response;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Kumbajah.Services.Services
{
    public class ProductService : IProductService
    {
        private IProductRepository ProductRepository { get; }
        private IValidator<Product> Validator { get; }

        public ProductService(IProductRepository productRepository)
        {
            ProductRepository = productRepository;
        }

        public async Task<ValidationResponse<ProductDTO>> CreateAsync(ProductDTO newProductDTO)
        {
            var product = newProductDTO.GetEntity();
            var validationResult = Validator.Validate(product);
            if (validationResult.IsValid)
            {
                var entity = await ProductRepository.CreateAsync(product);
                var dto = new ProductDTO(entity);
                return ValidationResponse<ProductDTO>.Valid(validationResult, dto);
            }
            else
            {
                return ValidationResponse<ProductDTO>.Invalid(validationResult);
            }
        }

        public async Task<ValidationResponse<ProductDTO>> UpdateAsync(ProductDTO updatedProductDto)
        {
            var updatedProduct = updatedProductDto.GetEntity();
            var validationResult = Validator.Validate(updatedProduct);
            if (validationResult.IsValid)
            {
                var entity = await ProductRepository.UpdateAsync(updatedProduct);
                var updatedDto = new ProductDTO(entity);
                return ValidationResponse<ProductDTO>.Valid(validationResult, updatedDto);
            }
            else
            {
                return ValidationResponse<ProductDTO>.Invalid(validationResult);
            }
        }

        public async Task DeleteAsync(int id) =>
            await ProductRepository.DeleteAsync(id);

        public List<ProductDTO> GetAllProducts()
        {
            var allProducts = ProductRepository.GetAll();
            var dtos = new List<ProductDTO>();
            foreach (var product in allProducts)
            {
                var dto = new ProductDTO(product.Id, product.Name,
                    product.Description, product.Price, product.Image,
                    product.CreatedTime, product.CategoryId,
                    product.StockId, product.ColorId.GetValueOrDefault(),
                    product.BrandId);
                dtos.Add(dto);
            }
            return dtos;
        }

        public ProductDTO GetById(int id)
        {
            var entity = ProductRepository.GetById(id);
            return new ProductDTO(entity);
        }

        public async Task<List<ProductDTO>> SearchByBrand(string brandName)
        {
            throw new System.NotImplementedException();
            //var allBrands = await ProductRepository.SearchByBrandName(brandName);
            //return Mapper.Map<List<ProductDTO>>(allBrands);
        }

        public async Task<List<ProductDTO>> SearchByCategoryName(string categoryName)
        {
            throw new System.NotImplementedException();
            //var allCategoriesName = await ProductRepository.SearchByCategoryName(categoryName);
            //return Mapper.Map<List<ProductDTO>>(allCategoriesName);
        }

        public async Task<List<ProductDTO>> SearchByProductName(string productName)
        {
            throw new System.NotImplementedException();
            //var allProductsName = await ProductRepository.SearchByProductName(productName);
            //return Mapper.Map<List<ProductDTO>>(allProductsName);
        }
    }
}
