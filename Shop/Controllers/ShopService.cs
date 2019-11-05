using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Models;

namespace Shop.Controllers
{
    public class ShopService : IShopService
    {
        private IRepository<Product> _repository;
        
        public ShopService(IRepository<Product> repository)
        {
            _repository = repository;
        }

        public IEnumerable<Product> GetProductsByCategory(int id)
        {
            return _repository.Get().Where(p => p.CategoryId == id);
        }
    }
}