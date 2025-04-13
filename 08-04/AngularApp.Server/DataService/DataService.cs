using AngularApp.Server.DTO;
using AngularApp.Server.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AngularApp.Server.DataService
{
    public class DataService : AngularApp.Server.IDataService.IDataService
    {
        private readonly MyDbContext _context;
        public DataService(MyDbContext context)
        {
            _context = context;
        }


        public List<Category> getAllCategories()
        {
            var categories = _context.Categories.ToList();
            return categories;
        }

        public Category getCategoryByID(int id)
        {
            var category = _context.Categories.Find(id);
            return category;
        }

        public List<Category> CategoryByName(string name)
        {
            var category = _context.Categories.Where(n => n.Name == name).ToList();
            return category;
        }
        public Category firstCategory()
        {
            var category = _context.Categories.First();
            return category;
        }

        public List<Product> getAllProducts()
        {
            var product = _context.Products.ToList();
            return product;
        }

        public List<Product> getProductName(string name)
        {
            var product = _context.Products.Where(n => n.Name == name).ToList();
            return product;
        }

        public Product getProductByID(int id)
        {
            var product = _context.Products.Find(id);
            return product;
        }

        public Product getProductFirst()
        {
            var product = _context.Products.First();
            return product;

        }

        public bool deleteCategory(int id)
        {
            var category = _context.Categories.Find(id);
            if (category != null)
            {
                _context.Categories.Remove(category);
                _context.SaveChanges();
                return true;
            }
            return false;

        }

        public bool deleteProduct(int id)
        {
            var product = _context.Products.Find(id);
            if (product != null)
            {
                _context.Products.Remove(product);
                _context.SaveChanges();
                return true;
            }
            return false;

        }


        public bool addCategory(addCategoryDTO category)
        {

            //if (category == null)
            //{
            //    return false;
            //}
            //else
            //{
            var category1 = new Category
            {
                Name = category.Name,
                Description = category.Description
            };
                 _context.Categories.Add(category1);
                 _context.SaveChanges ();
                return true;
            
           
        }

        public bool categoryUpdate(int id, updateCategoryDTO cateogry)
        {
            var category = _context.Categories.Find(id);
            if (category == null) { 
                return false;
            }
            else
            {
               category.Name = cateogry.Name;
                category.Description = cateogry.Description;
                _context.SaveChanges();
                return true;
            }
            
        }
    }
}
