using CleanArcMvc.Aplication.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArcMvc.Aplication.IServices
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDTO>> GetProductsAsync();
        Task<ProductDTO> GetByIdAsync(int? id);
        Task<ProductDTO> GetProductByCategoryAsync(int? id);
        Task<ProductDTO> CreateAsync(ProductDTO productDTO);
        Task<ProductDTO> UpdateAsync(ProductDTO productDTO);
        Task<ProductDTO> DeleteAsync(ProductDTO productDTO);
    }
}
