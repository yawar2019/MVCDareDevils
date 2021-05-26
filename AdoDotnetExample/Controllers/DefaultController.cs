using AdoDotnetExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AdoDotnetExample.Controllers
{
    public class DefaultController : Controller
    {
        EmployeeContext db = new EmployeeContext();
        // GET: Default
        public ActionResult Index()
        {
            return View(db.getEmployees());
        }
    }
}