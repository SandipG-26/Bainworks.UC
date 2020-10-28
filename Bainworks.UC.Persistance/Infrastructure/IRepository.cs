using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Brainworks.UC.Persistance
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T GetById (int Id);

        IEnumerable<T> Find(Expression<Func<T, bool>> predicate);
        T FirstOrDefault(Expression<Func<T, bool>> predicate);
        void Add(T entity);
        void remove(T entity);
        void update(T entity);
    }
}
 