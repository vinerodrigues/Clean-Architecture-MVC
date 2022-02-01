using CleanArcMvc.Domain.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArcMvc.Aplication.Products.Querys
{
    public class GetProductsQuery : IRequest<IEnumerable<Product>>
    {
    }
}
