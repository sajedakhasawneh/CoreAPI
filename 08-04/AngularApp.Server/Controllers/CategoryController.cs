using AngularApp.Server.DTO;
using AngularApp.Server.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AngularApp.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase

    {
        private readonly AngularApp.Server.IDataService.IDataService _data;

        public CategoryController(AngularApp.Server.IDataService.IDataService data)
        {
            _data = data;
        }

        [HttpGet]
        public IActionResult GetAllCategories()
        {
            var categories = _data.getAllCategories();
            return Ok(categories);
        }



        [HttpGet("categoryByID")]
        public IActionResult GetCategorybyID(int id)
        {
            var category = _data.getCategoryByID(id);
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
            var category = _data.CategoryByName(name);
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
            var category = _data.firstCategory();
            if (category != null)
            {
                return Ok(category);
            }
            else { 
            return NotFound();
                    }
        }

        [HttpDelete]
        public IActionResult deleteCategory(int id) 
        {
            var category = _data.deleteCategory(id);
            if (category != false)
            {   return Ok(category);
            }
            return NotFound();

        }

        [HttpPost]
        public IActionResult addCategory([FromBody] addCategoryDTO categorydto)
        {
            if (categorydto == null)
            {
                return BadRequest();   
            }
            else
            {
              bool cat = _data.addCategory(categorydto);
                if (cat == false)
                    return BadRequest();
                else { 
                    return Ok(cat);
                }
            }
          
        }

        [HttpPut]
        public IActionResult updateCategory(int id, [FromForm] updateCategoryDTO dto )
        {
            if(dto == null)
            {
                return BadRequest();
            }
            else
            {
                bool updateedCategory = _data.categoryUpdate(id, dto);
                if (updateedCategory == false)
                    return BadRequest();
                else 
                return Ok("student info updated successfully");
            }
        }
    }
}