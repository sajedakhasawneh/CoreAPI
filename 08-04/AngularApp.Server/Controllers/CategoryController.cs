using AngularApp.Server.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AngularApp.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly MyDbContext _context;

        public CategoryController(MyDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAllCategories()
        {
            var categories = _context.Categories.ToList();
            return Ok(categories);
        }

        [HttpGet("categoryByID")]
        public IActionResult GetCategorybyID(int id)
        {
            var category = _context.Categories.Find(id);
            if (category != null)
            {
                return Ok(category);
            }
            else
            {
                return NotFound();
            }
            
        }

        [HttpGet("categoryName")]
        public IActionResult getCategoryName(string name)
        {
            var category = _context.Categories.Where(n => n.Name == name).ToList();
            if (category != null)
            {
                return Ok(category);
            }
            else {
                return NotFound();
            }
        }

        [HttpGet("firstCategory")]
        public IActionResult getFirstCategory()
        {
            var category = _context.Categories.First();
            if (category != null)
            {
                return Ok(category);
            }
            else { 
            return NotFound();
                    }
        }
    }
}