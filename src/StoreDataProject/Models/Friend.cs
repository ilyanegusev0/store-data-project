using StoreDataProject.Interfaces;

namespace StoreDataProject.Models
{
    public class Friend : IEntity
    {
        public int Id { get; set; }
        public int Employee1 { get; set; }
        public int Employee2 { get; set; }

        public Friend(int employee1, int employee2)
        {
            Employee1 = employee1;
            Employee2 = employee2;
        }

        public override string ToString()
        {
            return $"ID: {Id} | Employee1: {Employee1} | Employee2: {Employee2}";
        }
    }
}
