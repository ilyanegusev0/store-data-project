using StoreDataProject.Data;
using StoreDataProject.Models;

namespace StoreDataProject.Repositories
{
    public class DBRepository
    {
        public DBTable<Product> Products { get; }
        public DBTable<Description> Descriptions { get; }
        public DBTable<Category> Categories { get; }
        public DBTable<ProductCategory> ProductCategories { get; }

        public DBRepository()
        {
            Products = new DBTable<Product>("Products");
            Descriptions = new DBTable<Description>("Descriptions");
            Categories = new DBTable<Category>("Categories");
            ProductCategories = new DBTable<ProductCategory>("ProductCategories");
        }
    }
}
