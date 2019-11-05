using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Shop.Controllers
{
    public class CategoryRepository : IRepository<Category>
    {
        public void Create(Category product)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Category> Get()
        {
            throw new NotImplementedException();
        }

        public Category GetById(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}