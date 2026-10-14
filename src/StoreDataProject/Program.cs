using StoreDataProject.Models;
using StoreDataProject.Repositories;
using StoreDataProject.Services;

namespace StoreDataProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Setting up

            Console.InputEncoding = System.Text.Encoding.UTF8;
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Initialization

            var repository = new DBRepository();
            var reportService = new ReportService();

            // Products
            var product1 = new Product("Apple iPhone 17", 43169);
            var product2 = new Product("Lenovo LOQ 15AHP10", 51099);
            var product3 = new Product("Poco X8 Pro Max", 21815);

            // Descriptions
            var description1 = new Description(2, "Ноутбуки серії Lenovo LOQ 15AHP10 середнього цінового сегменту з високою продуктивністю.");
            var description2 = new Description(3, "Глобальна версія примітного китайського смартфона Xiaomi Redmi Turbo 5 Max, що представляє сильний середній клас мобільних пристроїв.");
            var description3 = new Description(1, "Базова версія iPhone 17-го покоління, представлена у 2025 році.");

            // Categories
            var category1 = new Category("Мобільні телефони");
            var category2 = new Category("Ноутбуки");
            var category3 = new Category("Акційні пропозиції");

            // ProductCategories
            var productCategory1 = new ProductCategory(2, 2);
            var productCategory2 = new ProductCategory(3, 1);
            var productCategory3 = new ProductCategory(1, 1);
            var productCategory4 = new ProductCategory(3, 3);
            var productCategory5 = new ProductCategory(2, 3);

            // Customers
            var customer1 = new Customer("Alex");
            var customer2 = new Customer("Jhon");
            var customer3 = new Customer("Arthur");

            // Employees
            var employee1 = new Employee("Bill", "CEO", 1);
            var employee2 = new Employee("Bob", "Manager", 1);
            var employee3 = new Employee("Jane", "Worker", 2);
            var employee4 = new Employee("Kenny", "Worker", 2);

            // Friends
            var friend1 = new Friend(4, 3);
            var friend2 = new Friend(4, 1);
            var friend3 = new Friend(2, 3);
            var friend4 = new Friend(1, 2);

            // Orders
            var order1 = new Order("Order 1", 2, 4);
            var order2 = new Order("Order 2", 3, 3);

            // OrderProducts
            var orderProduct1 = new OrderProduct(2, 1);
            var orderProduct2 = new OrderProduct(2, 2);
            var orderProduct3 = new OrderProduct(1, 1);
            var orderProduct4 = new OrderProduct(1, 2);
            var orderProduct5 = new OrderProduct(1, 3);

            // Repository

            repository.Products.AddItem(product1);
            repository.Products.AddItem(product2);
            repository.Products.AddItem(product3);

            repository.Descriptions.AddItem(description1);
            repository.Descriptions.AddItem(description2);
            repository.Descriptions.AddItem(description3);

            repository.Categories.AddItem(category1);
            repository.Categories.AddItem(category2);
            repository.Categories.AddItem(category3);

            repository.ProductCategories.AddItem(productCategory1);
            repository.ProductCategories.AddItem(productCategory2);
            repository.ProductCategories.AddItem(productCategory3);
            repository.ProductCategories.AddItem(productCategory4);
            repository.ProductCategories.AddItem(productCategory5);

            // Demonstration

            reportService.DisplayReport(repository);
        }
    }
}
