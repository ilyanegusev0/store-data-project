using StoreDataProject.Interfaces;

namespace StoreDataProject.Data
{
    public class DBTable<T> : IRepository<T> where T : IEntity
    {
        private int _idCounter = 1;

        public string Name { get; }
        public List<T> Items { get; }

        public DBTable(string name)
        {
            Name = name;
            Items = new List<T>();
        }

        public void AddItem(T item)
        {
            item.Id = _idCounter++;
            Items.Add(item);
        }

        public T? GetById(int id)
        {
            return Items.Find(row => row.Id == id);
        }

        public void ShowItems()
        {
            Console.WriteLine(Name);
            Console.WriteLine(new string('-', Name.Length));
            foreach (var item in Items)
                Console.WriteLine(item);
        }
    }
}
