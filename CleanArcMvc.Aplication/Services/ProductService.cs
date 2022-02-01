using AutoMapper;
using CleanArcMvc.Aplication.DTOs;
using CleanArcMvc.Aplication.IServices;
using CleanArcMvc.Domain.IRepository;
using CleanArcMvc.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArcMvc.Aplication.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _autoMapper;
        
        public ProductService(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _autoMapper = mapper;
        }

        public async Task<ProductDTO> GetByIdAsync(int? id)
        {
            var productEntity = await _productRepository.GetByIdAsync(id);

            return _autoMapper.Map<ProductDTO>(productEntity);
        }

        public async Task<ProductDTO> GetProductByCategoryAsync(int? id)
        {
            var productEntity = await _productRepository.GetProductByCategoryAsync(id);

            return _autoMapper.Map<ProductDTO>(productEntity);
        }




        public async Task<IEnumerable<ProductDTO>> GetProductsAsync()
        {
            var productEntity = await _productRepository.GetProductsAsync();
            
            return _autoMapper.Map<IEnumerable<ProductDTO>>(productEntity);
        }

        public async Task<ProductDTO> CreateAsync(ProductDTO productDTO)
        {
            var productDTOEntity = _autoMapper.Map<Product>(productDTO);

            var productEntity = await _productRepository.CreateAsync(productDTOEntity);

            return _autoMapper.Map<ProductDTO>(productEntity);
        }

        public async Task<ProductDTO> DeleteAsync(ProductDTO productDTO)
        {
            var productDTOEntity = _autoMapper.Map<Product>(productDTO);

            var productEntity = await _productRepository.DeleteAsync(productDTOEntity);

            return _autoMapper.Map<ProductDTO>(productEntity);
        }

        public async Task<ProductDTO> UpdateAsync(ProductDTO productDTO)
        {
            var productDTOEntity = _autoMapper.Map<Product>(productDTO);

            var productEntity = await _productRepository.UpdateAsync(productDTOEntity);

            return _autoMapper.Map<ProductDTO>(productEntity);
        }
    }
}
