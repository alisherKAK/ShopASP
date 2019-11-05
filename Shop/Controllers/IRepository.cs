using System;
using System.Collections.Generic;

namespace Shop.Controllers
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> Get();
        T GetById(Guid id);
        void Create(T product);
    }
}
