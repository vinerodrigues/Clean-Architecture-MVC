﻿using CleanArcMvc.Aplication.IServices;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CleanArcMvc.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly ICategoryService _categoryService;

        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var categories = await _categoryService.GetCategoriesAsync();
            return View(categories);
        }
    }
}
