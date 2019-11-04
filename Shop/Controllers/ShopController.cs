using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Shop.Controllers
{
    public class ShopController : Controller
    {
        // GET: Shop
        public ActionResult Index()
        {
            //var cookie = new HttpCookie("userName", "admin");
            //cookie.Expires = DateTime.Now.AddMinutes(10);
            //HttpContext.Response.Cookies.Add(cookie);

            //Session["userName"] = Session.SessionID;
            //Session.Timeout = 50;
            //Session.Abandon();

            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }
    }
}