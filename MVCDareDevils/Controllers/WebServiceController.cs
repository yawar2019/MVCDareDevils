using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCDareDevils.ServiceReference1;
namespace MVCDareDevils.Controllers
{
    public class WebServiceController : Controller
    {
        // GET: WebService
        public ActionResult Index()
        {
            LakshmiWorldTourServiceSoapClient obj = new LakshmiWorldTourServiceSoapClient();
            int result = obj.add(10, 20);
            return Content(result.ToString());
        }

        public ActionResult getEmployees()
        {
            LakshmiWorldTourServiceSoapClient obj = new LakshmiWorldTourServiceSoapClient();
            List<EmployeeModel> result = obj.getEmployees().ToList();
            return View(result);
        }
    }
}