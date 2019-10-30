using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using Models;
using DataAccess;
using Services;

namespace WebApp24._10._19.Controllers
{
    public class ProductController : Controller
    {
        public ActionResult Index()
        {
            List<Models.Product> products;
            using(var context = new ShopContext())
            {
                products = context.Products.ToList();
            }
            return View(products);
        }

        public ActionResult Product(Guid id)
        {
            using(var context = new ShopContext())
            {
                return View(context.Products.ToList().FirstOrDefault(p => p.Id == id));
            }
        }

        public ActionResult CreateProduct(Product product)
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateProductPost(Product product)
        {
            if (ModelState.IsValid)
            {
                using (var context = new ShopContext())
                {
                    context.Products.Add(product);
                    context.SaveChanges();
                    Logger.Log(Server.MapPath("~/"), $"Added to DB Product: {product.Id}", "product");
                }
                return RedirectToAction("Index");
            }

            return RedirectToAction("CreateProduct", product);
        }

        [HttpPut]
        public ActionResult UpdateProductPut(Product product)
        {
            if (ModelState.IsValid)
            {
                using (var context = new ShopContext())
                {
                    context.Products.Add(product);
                    context.SaveChanges();
                    Logger.Log(Server.MapPath("~/"), $"Added to DB Product: {product.Id}", "product");
                }
                return RedirectToAction("Index");
            }

            return RedirectToAction("CreateProduct");
        }
    }
}