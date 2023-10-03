namespace WebApplication1.Interfaces
{
    public interface IRepository<T> where T : class, IEntity
    {
        IEnumerable<T> Get();
        T Get(int id);
        void Create(T item);
        void Update(T item);
        T Delete(int id);
    }
}
