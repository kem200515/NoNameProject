using System;
using System.Linq;
using System.Linq.Expressions;

namespace Database.Interface
{
    public interface IRepository<T>

    {

        T GetById(Guid id);

        IQueryable<T> GetAll();

        void Edit(T entity);

        void Insert(T entity);

        void Delete(T entity);

    }
}

