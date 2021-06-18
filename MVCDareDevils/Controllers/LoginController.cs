using MVCDareDevils.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace MVCDareDevils.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(UserDetail user)
        {
            EmployeeEntities db = new EmployeeEntities();
            UserDetail u = db.UserDetails.Where(x => x.UserName == user.UserName && x.Password == user.Password).SingleOrDefault();
            if (u != null)
            {
                FormsAuthentication.SetAuthCookie(user.UserName, false);
                return RedirectToAction("DashBoard");
            }
            else
            {
                return View();
            }
        }

        [Authorize(Roles = "Admin,Manager")]
        public ActionResult DashBoard()
        {
            return View();
        }

        [Authorize(Roles="Admin")]
        public ActionResult Contact()
        {
            return View();
        }
        [Authorize(Roles="Manager")]
        public ActionResult AboutUs()
        {
            return View();
        }
    }
}