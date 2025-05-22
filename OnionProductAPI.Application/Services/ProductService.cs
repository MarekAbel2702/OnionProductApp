using OnionProductAPI.Application.DTOs;
using OnionProductAPI.Application.Interfaces;
using OnionProductAPI.Domain.Entities;
using OnionProductAPI.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionProductAPI.Application.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _repository;

        public ProductService(IProductRepository repository)
        {
            _repository = repository;
        }

        public async Task<ProductDto> AddAsync(ProductDto dto)
        {
            var entity = new Product
            {
                Name = dto.Name,
                Description = dto.Description,
                Price = dto.Price,
                Quantity = dto.Quantity,
                Category = dto.Category,
                IsAvailable = dto.IsAvailable,
                CreatedAt = DateTime.UtcNow
        };

            await _repository.AddAsync(entity);

            return MapToDto(entity);
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var existing = await _repository.GetProductByIdAsync(id);
            if (existing == null) 
            {
                return false;
            }
            await _repository.DeleteAsync(id);
            return true;
        }

        public async Task<IEnumerable<ProductDto>> GetAllAsync()
        {
            var products = await _repository.GetAllAsync();
            return products.Select(p => MapToDto(p));
        }

        public async Task<ProductDto?> GetByIdAsync(int id)
        {
            var product = await _repository.GetProductByIdAsync(id);
            return product == null ? null : MapToDto(product);
        }

        public async Task<bool> UpdateAsync(ProductDto dto)
        {
            var existing = await _repository.GetProductByIdAsync(dto.Id);
            if (existing == null)
                return false;
            
            existing.Name = dto.Name;
            existing.Description = dto.Description;
            existing.Price = dto.Price;
            existing.Quantity = dto.Quantity;
            existing.Category = dto.Category;
            existing.IsAvailable = dto.IsAvailable;
            existing.UpdatedAt = DateTime.UtcNow;

            await _repository.UpdateAsync(existing);
            return true;
        }

        private ProductDto MapToDto(Product product)
        {
            return new ProductDto
            {
                Id = product.Id,
                Name = product.Name,
                Description = product.Description,
                Price = product.Price,
                Quantity = product.Quantity,
                Category = product.Category,
                IsAvailable = product.IsAvailable,
                CreatedAt = product.CreatedAt,
                UpdatedAt = product.UpdatedAt
            };
        }
    }
}
