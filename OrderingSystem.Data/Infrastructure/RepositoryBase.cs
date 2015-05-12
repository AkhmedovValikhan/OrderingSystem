using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderingSystem.Data.Infrastructure
{
    public abstract class RepositoryBase<T> : IRepository<T> where T : class
    {
        private readonly OrderingSystemEntities _context;
        private readonly IDbSet<T> _dbSet;
        protected RepositoryBase(IContextFactory factory)
        {
            _context = factory.Init();
            _dbSet = _context.Set<T>();
        }
        public virtual void Add(T entity)
        {
            _dbSet.Add(entity);
        }

        public virtual void Update(T entity)
        {
            _dbSet.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
        }

        public virtual void Delete(T entity)
        {
            _dbSet.Remove(entity);
        }

        public T FindById(int id)
        {
            return _dbSet.Find(id);
        }

        public T Find(System.Linq.Expressions.Expression<Func<T, bool>> condition)
        {
            return _dbSet.Where(condition).FirstOrDefault();
        }

        public IEnumerable<T> All()
        {
            return _dbSet.ToList();
        }

        public IEnumerable<T> Where(System.Linq.Expressions.Expression<Func<T, bool>> condition)
        {
            return _dbSet.Where(condition).ToList();
        }
    }
}
