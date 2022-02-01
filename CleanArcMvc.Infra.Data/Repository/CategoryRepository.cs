using CleanArcMvc.Domain.IRepository;
using CleanArcMvc.Domain.Models;
using CleanArcMvc.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CleanArcMvc.Infra.Data.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly AplicationDbContext _categoryContext;

        public CategoryRepository(AplicationDbContext context)
        {
            _categoryContext = context;
        }

        public async Task<Category> CreateAsync(Category category)
        {
            _categoryContext.Add(category);
            await _categoryContext.SaveChangesAsync();
            return category;
        }

        public async Task<Category> DeleteAsync(Category category)
        {
            _categoryContext.Remove(category);
            await _categoryContext.SaveChangesAsync();
            return category;
        }

        public async Task<Category> GetByIdAsync(int? id)
        {
            return await _categoryContext.Categories.FindAsync(id);
        }

        public async Task<IEnumerable<Category>> GetCategoriesAsync()
        {
            return await _categoryContext.Categories.ToListAsync();
        }

        public async Task<Category> UpdateAsync(Category category)
        {
            _categoryContext.Update(category);
            await _categoryContext.SaveChangesAsync();
            return category;
        }
    }
}
