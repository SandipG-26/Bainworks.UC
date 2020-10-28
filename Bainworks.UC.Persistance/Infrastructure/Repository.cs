using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Brainworks.UC.Persistance
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly UCcontext _context;
        public Repository(UCcontext context)
        {
            this._context = context;
        } 
        public void Add(T entity)
        {
            this._context.Set<T>().Add(entity);
        }

        public IEnumerable<T> Find(Expression<Func<T, bool>> predicate)
        {
            return this._context.Set<T>().Where(predicate);
        }

        public T FirstOrDefault(Expression<Func<T, bool>> predicate)
        {
            return this._context.Set<T>().FirstOrDefault(predicate);
        }

        public IEnumerable<T> GetAll()
        {
            return this._context.Set<T>();
        }

        public T GetById(int Id)
        {
            return this._context.Set<T>().Find(Id);
        }

        public void remove(T entity)
        {
            this._context.Set<T>().Remove(entity);
        }

        public void update(T entity)
        {
            this._context.Set<T>().Update(entity);
        }
    }
}
