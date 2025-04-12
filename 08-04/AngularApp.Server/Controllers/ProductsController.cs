using AngularApp.Server.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AngularApp.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly AngularApp.Server.IDataService.IDataService _data;

        public ProductsController(AngularApp.Server.IDataService.IDataService data)
        {
            _data = data;
        }


        [HttpGet]
        public IActionResult getAllProducts()
        {
            var product = _data.getAllProducts();
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
            var product = _data.getProductName(name);
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
            var product = _data.getProductByID(id);
            if (product != null) {
                return Ok(product);
            }
            else {  return NotFound();}
        }


        [HttpGet("first")]
        public IActionResult getProductFirst()
        {
            var product = _data.getProductFirst();
            if (product != null)
            {
                return Ok(product);
            }
            else { return NotFound(); }
        }

        [HttpDelete]
        public IActionResult deleteProduct(int id) 
        {
            var product = _data.deleteProduct(id);
            if (product != false)
            {
                return Ok(product);    
            }
            return NotFound();
        }
    }
}
