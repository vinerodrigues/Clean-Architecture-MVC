using CleanArcMvc.Aplication.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArcMvc.Aplication.IServices
{
    public interface ICategoryService
    {
        Task<IEnumerable<CategoryDTO>> GetCategoriesAsync();
        Task<CategoryDTO> GetByIdAsync(int? id);
        Task<CategoryDTO> CreateAsync(CategoryDTO category);
        Task<CategoryDTO> UpdateAsync(CategoryDTO category);
        Task<CategoryDTO> DeleteAsync(CategoryDTO category);
    }
}
