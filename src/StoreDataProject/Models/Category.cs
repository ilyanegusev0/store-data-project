using StoreDataProject.Interfaces;

namespace StoreDataProject.Models
{
    public class Category : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Category(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return $"ID: {Id} | Name: {Name}";
        }
    }
}
