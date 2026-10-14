using StoreDataProject.Repositories;

namespace StoreDataProject.Services
{
    public class ReportService
    {
        public void DisplayReport(DBRepository repository)
        {
            foreach (var product in repository.Products.Items)
            {
                var description = repository.Descriptions.Items
                    .Find(d => d.ProductId == product.Id);

                var categoryIds = repository.ProductCategories.Items
                    .Where(pc => pc.ProductId == product.Id)
                    .Select(pc => pc.CategoryId)
                    .ToList();

                var categoryNames = repository.Categories.Items
                    .Where(c => categoryIds.Contains(c.Id))
                    .Select(c => c.Name)
                    .ToList();

                Console.WriteLine($"{product.Name}\n" +
                    $"{new string('-', product.Name.Length)}\n" +
                    $"Description: {description.ProductDescription}\n" +
                    $"Categories: {string.Join(", ", categoryNames)}\n" +
                    $"Price: ₴{product.Price:F2}");

                Console.WriteLine();
            }
        }
    }
}
