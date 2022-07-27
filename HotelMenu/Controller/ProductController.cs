using HotelMenu.Models.dto;
using HotelMenu.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelMenu.Controller
{
    [Route("api/Product")]
    public class ProductController : ControllerBase
    {
        private IProductRepository _ProductRepository;
        private ResponseDto _Response;
        public ProductController(IProductRepository productRepository)
        {
            _ProductRepository = productRepository;
            _Response = new ResponseDto();
        }
        [HttpGet]
        public async Task<Object> GetProduct()
        {
            try
            {
                IEnumerable<ProductDto> productDtos = await _ProductRepository.GetProducts();
                _Response.Result = productDtos;
            }
            catch(Exception ex)
            {
                _Response.IsSuccess = false;
                _Response.ErrorMessage = new List<string>()
                {
                    ex.ToString()
                };
            }
            return _Response;
        }
        [HttpGet]
        [Route("{id}")]
        public async Task<Object> GetProductById(int id)
        {
            try
            {
                ProductDto productDtos = await _ProductRepository.GetProductById(id);
                _Response.Result = productDtos;
            }
            catch (Exception ex)
            {
                _Response.IsSuccess = false;
                _Response.ErrorMessage = new List<string>()
                {
                    ex.ToString()
                };
            }
            return _Response;
        }

        [HttpPost]
        public async Task<Object> CreateProduct([FromBody] ProductDto productDto)
        {
            try
            {
                ProductDto productDtos = await _ProductRepository.CreateProduct(productDto);
                _Response.Result = productDtos;
            }
            catch (Exception ex)
            {
                _Response.IsSuccess = false;
                _Response.ErrorMessage = new List<string>()
                {
                    ex.ToString()
                };
            }
            return _Response;
        }
        [HttpPut]
        public async Task<Object> UpdateProduct([FromBody] ProductDto productDto)
        {
            try
            {
                ProductDto productDtos = await _ProductRepository.UpdateProduct(productDto);
                _Response.Result = productDtos;
            }
            catch (Exception ex)
            {
                _Response.IsSuccess = false;
                _Response.ErrorMessage = new List<string>()
                {
                    ex.ToString()
                };
            }
            return _Response;
        }
        [HttpDelete]
        [Route("{id}")]
        public async Task<Object> DeleteProduct(int id)
        {
            try
            {
                bool result = await _ProductRepository.DeleteProductById(id);
                _Response.Result = result;
            }
            catch (Exception ex)
            {
                _Response.IsSuccess = false;
                _Response.ErrorMessage = new List<string>()
                {
                    ex.ToString()
                };
            }
            return _Response;
        }
    }
}
