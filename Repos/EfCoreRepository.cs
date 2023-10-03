using Microsoft.EntityFrameworkCore;
using WebApplication1.Interfaces;

namespace WebApplication1.Repos
{
    public abstract class EfCoreRepository<TEntity, TContext> : IRepository<TEntity> where TEntity : class, IEntity where TContext : DbContext
    {
        private TContext Context;
        private DbSet<TEntity> _dbSet;

        public IEnumerable<TEntity> Get()
        {
            return _dbSet.AsNoTracking().ToList();
        }
        public TEntity Get(int Id)
        {
            return Context.Set<TEntity>().Find(Id);
        }
        public EfCoreRepository(TContext context)
        {
            Context = context;
            _dbSet = context.Set<TEntity>();
        }
        public void Create(TEntity item)
        {
            _dbSet.Add(item);
            Context.SaveChanges();
        }
        public void Update(TEntity updatedTodoItem)
        {
            Context.Entry(updatedTodoItem).State = EntityState.Modified;
            Context.SaveChanges();
        }

        public TEntity Delete(int Id)
        {
            TEntity item = Get(Id);

            if (item != null)
            {
                _dbSet.Remove(item);
                Context.SaveChanges();
            }

            return item;
        }
    }
}
