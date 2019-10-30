using DataAccess;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApp24._10._19.Controllers
{
    public class UserController : Controller
    {
        public ActionResult Test()
        {
            return File("/Content/Blackhole.jpg", "text");
        }
        // GET: User
        public ActionResult SignUp(User user)
        {
            return View(user);
        }
        [HttpPost]
        public ActionResult SignUpPost(User user)
        {
            if (ModelState.IsValid)
            {
                using (var context = new ShopContext())
                {
                    context.Users.Add(user);
                    context.SaveChanges();
                    Logger.Log(Server.MapPath("~/"), $"Added to DB User: {user.Id}", "user");
                }
                return RedirectToAction("SignIn", user);
            }

            return RedirectToAction("SignUp", user);
        }

        public ActionResult SignIn(User user)
        {
            return View(user);
        }
        [HttpPost]
        public ActionResult SignInPost(User user)
        {
            using(var context = new ShopContext())
            {
                if(context.Users.Any(u => u.Login == user.Login && u.Password == user.Password))
                {
                    return new RedirectResult("/Product/Index");
                }
            }

            return RedirectToAction("SignIn", user);
        }
    }
}