using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCDareDevils.ServiceReference1;
using MVCDareDevils.ServiceReference2;
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

        public ActionResult getEmployees2()
        {
            Service1Client obj1 = new Service1Client();
            obj1.Add(10, 25);
            return Content(obj1.Add(10, 25).ToString());
        }
    }
}