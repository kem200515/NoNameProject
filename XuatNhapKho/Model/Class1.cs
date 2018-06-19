﻿using Repository.Interface;
using System;
using System.Data.Linq;
using System.Linq;
using System.Linq.Expressions;

namespace Xamlized.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        internal Table<T> DataTable;

        public Repository(DataContext dataContext)
        {
            DataTable = dataContext.GetTable<T>();
        }

        public void Insert(T entity)
        {
            DataTable.InsertOnSubmit(entity);
        }

        public void Delete(T entity)
        {
            DataTable.DeleteOnSubmit(entity);
        }

        public IQueryable<T> Search
              (Expression<Func<T, bool>> predicate)
        {
            return DataTable.Where(predicate);
        }

        public IQueryable<T> GetAll()
        {
            return DataTable;
        }
    }
}