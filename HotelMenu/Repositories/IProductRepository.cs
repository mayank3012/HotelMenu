using HotelMenu.Models.dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelMenu.Repositories
{
    public interface IProductRepository
    {
        public Task<ProductDto> CreateProduct(ProductDto productDto);
        public Task<ProductDto> UpdateProduct(ProductDto productDto);
        public Task<IEnumerable<ProductDto>> GetProducts();
        public Task<ProductDto> GetProductById(int id);
        public Task<bool> DeleteProductById(int id);
    }
}
