using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.IdentityStuff;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        [Authorize]
        public ActionResult Index()
        {
            MyIdentityDbContext db = new MyIdentityDbContext();
            UserStore<MyIdentityUser> userStore = new UserStore<MyIdentityUser>(db);
            UserManager<MyIdentityUser> userManager = new UserManager<MyIdentityUser>(userStore);

            MyIdentityUser user = userManager.FindByName(HttpContext.User.Identity.Name);

            //NorthwindEntities northwindDb = new NorthwindEntities();
            //List<Customer> model = null;
            string name = null;
            if (userManager.IsInRole(user.Id, "Administrator"))
            {
                name = "admin";
            }

            if (userManager.IsInRole(user.Id, "Operator"))
            {
                name = "operator";
            }

            ViewBag.FullName = user.FullName;

            return View(user);
        }


        [Authorize]
        public ActionResult ShowData()
        {
            MyIdentityDbContext db = new MyIdentityDbContext();
            UserStore<MyIdentityUser> userStore = new UserStore<MyIdentityUser>(db);
            UserManager<MyIdentityUser> userManager = new UserManager<MyIdentityUser>(userStore);

            MyIdentityUser user = userManager.FindByName(HttpContext.User.Identity.Name);

            //NorthwindEntities northwindDb = new NorthwindEntities();
            //List<Customer> model = null;
            string name = null;
            if (userManager.IsInRole(user.Id, "Administrator"))
            {
                name = "admin";
            }

            if (userManager.IsInRole(user.Id, "Operator"))
            {
                name = "operator";
            }

            ViewBag.FullName = user.FullName;

            return View();
        }

        public void Delete(string name)
        {
            string Name = name;
        }
    }
}