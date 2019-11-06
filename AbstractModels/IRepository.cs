﻿using System.Collections.Generic;

namespace AbstractModels
{
    public interface IRepository<T> where T : class
    {
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
        IEnumerable<T> GetAll();
    }
}
