using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDareDevils.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default added for srinivas
        public ActionResult Index(int? id)
        {
            return View();
        }
    }
}