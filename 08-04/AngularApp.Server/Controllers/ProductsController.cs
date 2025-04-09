using AngularApp.Server.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AngularApp.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly MyDbContext _context;
        public ProductsController(MyDbContext context) { 
            _context = context; 
        }


        [HttpGet]
        public IActionResult getAllProducts()
        {
            var product = _context.Products.ToList();
            if (product != null)
            {
                return Ok(product);
            }
            else {
                return NotFound(); 
            }
        }


        [HttpGet("Name")]
        public IActionResult getProductName(string name)
        {
            var product = _context.Products.FirstOrDefault(x => x.Name == name);
            if (product != null)
            {
                return Ok(product);
            }
            else 
            { 
                return NotFound();
            }
        }

        [HttpGet("byID")]
        public IActionResult getProductByID(int id) {
            var product = _context.Products.Find();
            if (product != null) {
                return Ok(product);
            }
            else {  return NotFound();}
        }


        [HttpGet("first")]
        public IActionResult getProductFirst() {
            var product = _context.Products.First();
            if (product != null) {
                return Ok(product);    
            }
            else { return NotFound();}
        }
    }
}
