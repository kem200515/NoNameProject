﻿using System;
using System.Linq;
using System.Linq.Expressions;

namespace Repository.Interface
{
    public interface IRepository<T>

    {

        T GetById(int id);

        IQueryable<T> GetAll();

        void Edit(T entity);

        void Insert(T entity);

        void Delete(T entity);

    }
}

