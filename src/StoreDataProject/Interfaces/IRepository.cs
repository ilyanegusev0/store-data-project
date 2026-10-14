namespace StoreDataProject.Interfaces
{
    public interface IRepository<T> where T : IEntity
    {
        string Name { get; }
        List<T> Items { get; }

        void AddItem(T item);
        T? GetById(int id);
        void ShowItems();
    }
}
