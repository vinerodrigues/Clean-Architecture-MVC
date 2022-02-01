using CleanArcMvc.Aplication.Products.Command;
using CleanArcMvc.Domain.IRepository;
using CleanArcMvc.Domain.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArcMvc.Aplication.Products.Handlers
{
    public class ProductRemoveCommandHandler : IRequestHandler<ProductRemoveCommand, Product>
    {
        private readonly IProductRepository _productRepository;

        public ProductRemoveCommandHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
    
        public async Task<Product> Handle(ProductRemoveCommand request, CancellationToken cancellationToken)
        {
            var product = await _productRepository.GetByIdAsync(request.Id);

            if (product == null)
            {
                throw new ApplicationException($"Entity could not be found");
            }
            else
            {
                return await _productRepository.DeleteAsync(product);
            }
        }
    }
}
