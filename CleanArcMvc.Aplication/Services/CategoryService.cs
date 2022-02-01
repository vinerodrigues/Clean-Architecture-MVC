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
    public class CategoryService : ICategoryService
    {
        public readonly ICategoryRepository _categoryRepository;
        public readonly IMapper _autoMapper;

        public CategoryService(ICategoryRepository categoryRepository, IMapper autoMapper)
        {
            _categoryRepository = categoryRepository;
            _autoMapper = autoMapper;
        }

        public async Task<IEnumerable<CategoryDTO>> GetCategoriesAsync()
        {
            var categoriesEntity = await _categoryRepository.GetCategoriesAsync();

            return _autoMapper.Map<IEnumerable<CategoryDTO>>(categoriesEntity);
        }

        public async Task<CategoryDTO> GetByIdAsync(int? id)
        {
            var categoryEntity = await _categoryRepository.GetByIdAsync(id);

            return _autoMapper.Map<CategoryDTO>(categoryEntity);
        }

        public async Task<CategoryDTO> CreateAsync(CategoryDTO categoryDTO)
        {
            var categoryDTOEntity = _autoMapper.Map<Category>(categoryDTO);

            var categoryEntity =  await _categoryRepository.CreateAsync(categoryDTOEntity);

            return _autoMapper.Map<CategoryDTO>(categoryEntity);
        }

        public async Task<CategoryDTO> DeleteAsync(CategoryDTO categoryDTO)
        {
            var categoryDTOEntity = _autoMapper.Map<Category>(categoryDTO);

            var categoryEntity = await _categoryRepository.DeleteAsync(categoryDTOEntity);

            return _autoMapper.Map<CategoryDTO>(categoryEntity);
        }

        public async Task<CategoryDTO> UpdateAsync(CategoryDTO categoryDTO)
        {
            var categoryDTOEntity = _autoMapper.Map<Category>(categoryDTO);

            var categoryEntity = await _categoryRepository.DeleteAsync(categoryDTOEntity);

            return _autoMapper.Map<CategoryDTO>(categoryEntity);

        }
    }
}
