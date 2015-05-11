using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OrderingSystem.Data.Infrastructure
{
    public interface IRepository<T> where T : class
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

        T FindById(int id);
        T Find(Expression<Func<T, bool>> condition);

        IEnumerable<T> All();
        IEnumerable<T> Where(Expression<Func<T, bool>> condition);
    }
}
