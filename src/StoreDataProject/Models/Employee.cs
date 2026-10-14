using StoreDataProject.Interfaces;

namespace StoreDataProject.Models
{
    public class Employee : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public int ChiefId { get; set; }

        public Employee(string name, string position, int chiefId)
        {
            Name = name;
            Position = position;
            ChiefId = chiefId;
        }

        public override string ToString()
        {
            return $"ID: {Id} | Name: {Name} | Position: {Position} | ChiefId: {ChiefId}";
        }
    }
}
