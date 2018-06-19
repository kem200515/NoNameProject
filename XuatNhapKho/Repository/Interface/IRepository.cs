using System;
using System.Linq;
using System.Linq.Expressions;

namespace Repository.Interface
{
    public interface IRepository<T>
    {
        void Insert(T entity);
        void Delete(T entity);
        IQueryable<T> Search(Expression<Func<T, bool>> predicate);
        IQueryable<T> GetAll();
    }
}

