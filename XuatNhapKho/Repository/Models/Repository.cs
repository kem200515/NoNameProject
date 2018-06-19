using Repository.Interface;
using System;
using System.Data.Linq;
using System.Linq;
using System.Linq.Expressions;

namespace Repository.Models
{
    public class Repository<T> : IRepository<T> where T : class
    {
        internal Table<T> DataTable;

        public Repository(DataContext dataContext)
        {
            DataTable = dataContext.GetTable<T>();
        }
        public void Delete(T entity)
        {
            DataTable.DeleteOnSubmit(entity);
        }

        public IQueryable<T> GetAll()
        {
            return DataTable;
        }

        public void Insert(T entity)
        {
            DataTable.InsertOnSubmit(entity);
        }

        public IQueryable<T> Search(Expression<Func<T, bool>> predicate)
        {
            return DataTable.Where(predicate);
        }
    }
}