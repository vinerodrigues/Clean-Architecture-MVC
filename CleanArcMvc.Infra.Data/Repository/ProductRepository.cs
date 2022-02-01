using CleanArcMvc.Domain.IRepository;
using CleanArcMvc.Domain.Models;
using CleanArcMvc.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CleanArcMvc.Infra.Data.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly AplicationDbContext _productContext;
        public ProductRepository(AplicationDbContext productContext)
        {
            _productContext = productContext;
        }
        public async Task<Product> CreateAsync(Product product)
        {
            _productContext.Add(product);
            await _productContext.SaveChangesAsync();
            return product;
        }

        public async Task<Product> DeleteAsync(Product product)
        {
            _productContext.Remove(product);
            await _productContext.SaveChangesAsync();
            return product;
        }

        public async Task<Product> GetByIdAsync(int? id)
        {
            return await _productContext.Products.FindAsync(id);
        }

        public async Task<Product> GetProductByCategoryAsync(int? id)
        {
            //eagler loading (Carregamento Adiantado)
            //Ele traz o produto com a Categoria
            return await _productContext.Products.Include(c => c.Category).SingleOrDefaultAsync(p => p.Id == id);
        }

        public async Task<IEnumerable<Product>> GetProductsAsync()
        {
            return await _productContext.Products.ToListAsync();
        }

        public async Task<Product> UpdateAsync(Product product)
        {
            _productContext.Update(product);
            await _productContext.SaveChangesAsync();
            return product;
        }
    }
}
