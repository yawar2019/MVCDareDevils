using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDareDevils.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default Great News
        public ActionResult Index()
        {
            return View();
        }
    }
}