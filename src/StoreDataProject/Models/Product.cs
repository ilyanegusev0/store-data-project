using StoreDataProject.Interfaces;

namespace StoreDataProject.Models
{
    public class Product : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public Product(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return $"ID: {Id} | Name: {Name} | Price: ₴{Price:F2}";
        }
    }
}
