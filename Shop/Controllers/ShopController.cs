using DataAccess;
using Models;
using Ninject;
using Services;
using Shop.App_Start;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Shop.Controllers
{
    public class ShopController : Controller
    {
        private readonly RepositoryFactory factory;

        public ShopController(RepositoryFactory factory)
        {
            this.factory = factory;
        }
        public ActionResult Index()
        {
            return View();
        }
        [Route("home/{name}")]
        public ActionResult About(int? name)
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }
    }
}