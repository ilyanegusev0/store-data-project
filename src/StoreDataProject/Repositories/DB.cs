using StoreDataProject.Data;
using StoreDataProject.Models;

namespace StoreDataProject.Repositories
{
    public class DB
    {
        public DBTable<Product> Products { get; }
        public DBTable<Description> Descriptions { get; }
        public DBTable<Category> Categories { get; }
        public DBTable<ProductCategory> ProductCategories { get; }
        public DBTable<Customer> Customers { get; }
        public DBTable<Employee> Employees { get; }
        public DBTable<Order> Orders { get; }
        public DBTable<OrderProduct> OrderProducts { get; }
        public DBTable<Friend> Friends { get; }

        public DB()
        {
            Products = new DBTable<Product>("Products");
            Descriptions = new DBTable<Description>("Descriptions");
            Categories = new DBTable<Category>("Categories");
            ProductCategories = new DBTable<ProductCategory>("ProductCategories");
            Customers = new DBTable<Customer>("Customers");
            Employees = new DBTable<Employee>("Employees");
            Orders = new DBTable<Order>("Orders");
            OrderProducts = new DBTable<OrderProduct>("OrderProducts");
            Friends = new DBTable<Friend>("Friends");

        }
    }
}
