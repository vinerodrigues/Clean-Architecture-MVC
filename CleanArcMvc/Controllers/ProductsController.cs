using CleanArcMvc.Aplication.IServices;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CleanArcMvc.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductService _productServices;

        public ProductsController(IProductService productServices)
        {
            _productServices = productServices;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var products = await _productServices.GetProductsAsync();
            
            return View(products);
        }
    }
}

