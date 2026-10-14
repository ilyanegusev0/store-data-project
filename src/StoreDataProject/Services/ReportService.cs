using StoreDataProject.Models;
using StoreDataProject.Repositories;

namespace StoreDataProject.Services
{
    public class ReportService
    {
        public void DisplayReport(DB db)
        {
            Console.WriteLine("PRODUCTS:");
            foreach (var product in db.Products.Items)
            {
                var description = db.Descriptions.Items
                    .Find(d => d.ProductId == product.Id);

                var categoryIds = db.ProductCategories.Items
                    .Where(pc => pc.ProductId == product.Id)
                    .Select(pc => pc.CategoryId)
                    .ToList();

                var categories = db.Categories.Items
                    .Where(c => categoryIds.Contains(c.Id))
                    .ToList();

                var formattedCategories = string.Join(", ", categories.Select(c => c.Name));

                Console.WriteLine($"{new string('-', 100)}\n" +
                    $"{product.Name}\n" +
                    $"{new string('-', product.Name.Length)}\n" +
                    $"DESCRIPTION: {description.ProductDescription}\n" +
                    $"CATEGORIES: {formattedCategories}\n" +
                    $"PRICE: ₴{product.Price:F2}");
            }
            Console.WriteLine(new string('-', 100));

            Console.WriteLine("\nORDERS:");
            foreach (var order in db.Orders.Items)
            {
                var customer = db.Customers.Items
                    .Find(c => c.Id == order.CustomerId);

                var employee = db.Employees.Items
                    .Find(e => e.Id == order.EmployeeId);

                var productIds = db.OrderProducts.Items
                    .Where(p => p.OrderId == order.Id)
                    .Select(p => p.Id);

                var products = db.Products.Items
                    .Where(p => productIds.Contains(p.Id))
                    .Select(p => $" - {p.Name}");

                var totalPrice = db.Products.Items
                    .Where(p => productIds.Contains(p.Id))
                    .Select(p => p.Price)
                    .Sum();

                Console.WriteLine($"{new string('-', 100)}\n" +
                    $"{order.OrderName}\n" +
                    $"{new string('-', order.OrderName.Length)}\n" +
                    $"CUSTOMER: {customer.Name}\n" +
                    $"EMPLOYEE: {employee.Name}\n" +
                    $"TOTAL PRICE: ₴{totalPrice}\n\n" +
                    $"PRODUCTS:\n" +
                    $"{string.Join(Environment.NewLine, products)}");
            }
            Console.WriteLine(new string('-', 100));

            Console.WriteLine("\nCUSTOMERS:");
            foreach (var customer in db.Customers.Items)
            {
                var orders = db.Orders.Items
                    .Where(o => o.CustomerId == customer.Id)
                    .ToList();

                var formattedOrders = string.Join(Environment.NewLine, orders.Select(o => $" - {o.OrderName}"));

                Console.WriteLine($"{new string('-', 100)}\n" +
                    $"{customer.Name}\n" +
                    $"{new string('-', customer.Name.Length)}\n" +
                    $"ORDERS ({orders.Count}):\n" +
                    $"{formattedOrders}");
            }
            Console.WriteLine(new string('-', 100));

            Console.WriteLine("\nEMPLOYEES:");
            foreach (var employee in db.Employees.Items)
            {
                var chief = db.Employees.Items
                    .Find(e => e.Id == employee.ChiefId);

                var friendsIds = db.Friends.Items
                    .Where(f => f.Employee1 == employee.Id)
                    .Select(f => f.Employee2)
                    .ToList();

                var friends = db.Employees.Items
                    .Where(e => friendsIds.Contains(e.Id))
                    .ToList();

                var formattedFriends = string.Join(Environment.NewLine, friends.Select(f => $" - {f.Name}"));

                var orders = db.Orders.Items
                    .Where(o => o.EmployeeId == employee.Id)
                    .ToList();

                var formattedOrders = string.Join(Environment.NewLine, orders.Select(o => $" - {o.OrderName}"));

                Console.WriteLine($"{new string('-', 100)}\n" +
                    $"{employee.Name}\n" +
                    $"{new string('-', employee.Name.Length)}\n" +
                    $"POSITION: {employee.Position}\n" +
                    $"CHIEF: {chief.Name}\n\n" +
                    $"FRIENDS ({friends.Count}):\n" +
                    $"{formattedFriends}\n\n" +
                    $"ORDERS ({orders.Count}):\n" +
                    $"{formattedOrders}");
            }
            Console.WriteLine(new string('-', 100));
        }
    }
}
