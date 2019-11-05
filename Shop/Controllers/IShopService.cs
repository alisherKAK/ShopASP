using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Controllers
{
    public interface IShopService
    {
        IEnumerable<Product> GetProductsByCategory(int id);
    }
}
