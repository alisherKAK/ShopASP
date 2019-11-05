using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DataAccess;
using Models;

namespace Shop.Controllers
{
    public class ProductRepository : IRepository<Product>
    {
        public ShopContext _context = new ShopContext();

        public void Create(Product product)
        {
            _context.Products.Add(product);
        }

        public IEnumerable<Product> Get()
        {
            return _context.Products.ToList();
        }

        public Product GetById(Guid id)
        {
            return _context.Products.Where(p => p.Id == id).FirstOrDefault();
        }
    }
}