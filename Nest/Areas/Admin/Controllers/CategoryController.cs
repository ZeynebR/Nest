using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Nest.Data;
using Nest.Models;

namespace Nest.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private readonly AppDbContext _context;

        public CategoryController(AppDbContext context)
        {
            _context = context;
        }

        public async Task< IActionResult> Index()
        {
            var categories =await _context.Categories.Include(x=>x.Products).ToListAsync();
            return View(categories);
        }

        public IActionResult Create()
        { 
            return View();
        }
        [HttpPost]  

        public IActionResult Create(Category category)
        {
            return View();
        }
    }
}
