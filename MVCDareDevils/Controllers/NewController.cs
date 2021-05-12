using MVCDareDevils.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDareDevils.Controllers
{
    public class NewController : Controller
    {
        public string helloWorld(string name)//new/helloworld/1/askdfas
        {
            return "Thunder";
        }

        public string helloWorld2(int? id,string name)
        {
            return "My Employee Id is: "+id+" Name: "+name;
        }

        [Route("animal/lion")]
        [Route("animal/tiger")]
        [Route("animal/cheetah")]
        public string helloWorld3()
        {
            string s= helloWorld23();
            return s;
        }


        public ActionResult MYSimpleDay()
        {

            return View();
        }
        public ActionResult MYSimpleDay1()
        {
            return View("Kitten");
        }

        public ActionResult MYSimpleDay2()
        {
            return View("~/Views/Default/Index.cshtml");
        }

        private string helloWorld23()
        {
            return "hi frnds";
        }
        [NonAction]
        public string helloWorld24()
        {
            return "hi frnds";
        }

        public int GetEmpId(int empid) {

            return empid;
        }

        public ActionResult MyfavoriteDay()
        {
            ViewBag.info = true;
            return View();
        }

        public ActionResult MyfavoriteDay2()
        {
            ViewBag.info = true;
            return View();
        }

        public ActionResult MyfavoriteDay3()
        {
            EmployeeModel obj = new EmployeeModel();
            obj.EmpId = 1;
            obj.EmpName = "Lakshmi";
            obj.EmpSalary = 2310000;

            ViewBag.info = obj;

            return View();
        }
    }
}