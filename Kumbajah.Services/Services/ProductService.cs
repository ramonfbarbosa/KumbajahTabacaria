using FluentValidation;
using Kumbajah.Domain.Entities;
using Kumbajah.Infra.Interfaces;
using Kumbajah.Infra.Pagination;
using Kumbajah.Services.DTO;
using Kumbajah.Services.Interfaces;
using KumbajahTabacaria.Infra.Pagination;
using KumbajahTabacaria.Response;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public List<ProductDTO> GetAll()
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

        public async Task<ValidationResponse<ProductDTO>> CreateAsync(ProductDTO newProductDTO)
        {
            var product = newProductDTO.GetEntity();
            var validationResult = Validator.Validate(product, o => o.IncludeRuleSets("Create"));
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
            var validationResult = Validator.Validate(updatedProduct, o => o.IncludeRuleSets("CreateOrUpdate"));
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

        public async Task<string> DeleteAsync(int id)
        {
            var isProduct = await ProductRepository.DeleteAsync(id);
            if (isProduct != null)
            {
                return "Produto removido!";
            }
            return null;
        }

        public PaginationResponse<ProductDTO> PagedProducts(ListCriteria criteria)
        {
            if (criteria == null)
            {
                throw new ArgumentNullException(nameof(criteria));
            }
            var filteredProducts = ProductRepository.Filter(criteria.Filter);
            var orderedProducts = ProductRepository.OrderBy(filteredProducts, criteria.Sortings);
            var paginatedProducts = orderedProducts.Paginate(criteria.Pagination);
            var productsDTO = paginatedProducts.Select(product => new ProductDTO(product));
            return new PaginationResponse<ProductDTO>(filteredProducts.Count(), productsDTO.ToList());
        }
    }
}
