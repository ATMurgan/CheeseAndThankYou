﻿using CheeseAndThankYou.Data;
using CheeseAndThankYou.Models;
using Microsoft.AspNetCore.Mvc;

namespace CheeseAndThankYou.Controllers
{
    public class ShopController : Controller
    {
        // db connection for all methods in controller
        private readonly ApplicationDbContext _context;

        // Constructor w/db connection dependency
        public ShopController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            // Fecth list of categories & pass to view for display
            var categories = _context.Categories.ToList();
            return View(categories);
        }

        // GET: /Shop/ByCategory/5
        public IActionResult ByCategory(int id)
        {
            // make sure we have a valid Category Id 
            // Fetch list of products in seelcted category & pass to view
            if (id == 0)
            {
                return RedirectToAction("Index");

            }
            var products = _context.Products.Where(p => p.CategoryId == id).ToList();

         return View(products);
            
        }
    }
}
