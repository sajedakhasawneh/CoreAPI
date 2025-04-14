using AngularApp.Server.DTO;
using AngularApp.Server.Models;
using Microsoft.EntityFrameworkCore;

namespace AngularApp.Server.IDataService
{
    public interface IDataService
    {
        public List<Category> getAllCategories();
        public Category getCategoryByID(int id);
        public List<Category> CategoryByName(string name);
        public Category firstCategory();

        public List<Product> getAllProducts();
        public List<Product> getProductName(string name);
        public Product getProductByID(int id);

        public Product getProductFirst();

        public bool deleteCategory(int id);
        public bool deleteProduct(int id);

        public bool addCategory(addCategoryDTO category);
        public bool categoryUpdate(int id, updateCategoryDTO cateogry);
        public bool newProduct(addProductDTO dto);

    }

}
