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

        public string helloWorld2(int? id, string name)
        {
            return "My Employee Id is: " + id + " Name: " + name;
        }

        [Route("animal/lion")]
        [Route("animal/tiger")]
        [Route("animal/cheetah")]
        public string helloWorld3()
        {
            string s = helloWorld23();
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

        public int GetEmpId(int empid)
        {

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

        public ActionResult MyfavoriteDay4()
        {
            List<EmployeeModel> listemployee = new List<EmployeeModel>();

            EmployeeModel obj = new EmployeeModel();
            obj.EmpId = 1;
            obj.EmpName = "Lakshmi";
            obj.EmpSalary = 2310000;

            EmployeeModel obj1 = new EmployeeModel();
            obj1.EmpId = 2;
            obj1.EmpName = "Namrata";
            obj1.EmpSalary = 4310000;

            EmployeeModel obj2 = new EmployeeModel();
            obj2.EmpId = 3;
            obj2.EmpName = "vamshi";
            obj2.EmpSalary = 4310000;

            listemployee.Add(obj);
            listemployee.Add(obj1);
            listemployee.Add(obj2);

            ViewBag.info = listemployee;

            return View();
        }

        public ActionResult MyfavoriteDay5()
        {
            EmployeeModel obj = new EmployeeModel();
            obj.EmpId = 1;
            obj.EmpName = "Lakshmi";
            obj.EmpSalary = 2310000;
            return View(obj);
        }
        public ViewResult MyfavoriteDay6()
        {
            List<EmployeeModel> listemployee = new List<EmployeeModel>();

            EmployeeModel obj = new EmployeeModel();
            obj.EmpId = 1;
            obj.EmpName = "Lakshmi";
            obj.EmpSalary = 2310000;

            EmployeeModel obj1 = new EmployeeModel();
            obj1.EmpId = 2;
            obj1.EmpName = "Namrata";
            obj1.EmpSalary = 4310000;

            EmployeeModel obj2 = new EmployeeModel();
            obj2.EmpId = 3;
            obj2.EmpName = "vamshi";
            obj2.EmpSalary = 4310000;

            listemployee.Add(obj);
            listemployee.Add(obj1);
            listemployee.Add(obj2);

            return View(listemployee);
        }

        public RedirectResult GetmeToGoogle()
        {
            return Redirect("https://www.google.co.in/webhp?source=search_app");
        }

        public RedirectResult GetmeToLocalUrl()
        {
            return Redirect("~/Default/Index?id=1");
        }

        public ActionResult PartialViewExample()
        {
            List<EmployeeModel> listemployee = new List<EmployeeModel>();

            EmployeeModel obj = new EmployeeModel();
            obj.EmpId = 1;
            obj.EmpName = "Lakshmi";
            obj.EmpSalary = 2310000;

            EmployeeModel obj1 = new EmployeeModel();
            obj1.EmpId = 2;
            obj1.EmpName = "Namrata";
            obj1.EmpSalary = 4310000;

            EmployeeModel obj2 = new EmployeeModel();
            obj2.EmpId = 3;
            obj2.EmpName = "vamshi";
            obj2.EmpSalary = 4310000;

            listemployee.Add(obj);
            listemployee.Add(obj1);
            listemployee.Add(obj2);
            return View(listemployee);
        }
        public PartialViewResult PartialViewExample2()
        {
            List<EmployeeModel> listemployee = new List<EmployeeModel>();

            EmployeeModel obj = new EmployeeModel();
            obj.EmpId = 1;
            obj.EmpName = "Lakshmi";
            obj.EmpSalary = 2310000;

            EmployeeModel obj1 = new EmployeeModel();
            obj1.EmpId = 2;
            obj1.EmpName = "Namrata";
            obj1.EmpSalary = 4310000;

            EmployeeModel obj2 = new EmployeeModel();
            obj2.EmpId = 3;
            obj2.EmpName = "vamshi";
            obj2.EmpSalary = 4310000;

            listemployee.Add(obj);
            listemployee.Add(obj1);
            listemployee.Add(obj2);
            return PartialView("_MyPartialView", listemployee);
        }

        public JsonResult GetMeData()
        {

            List<EmployeeModel> listemployee = new List<EmployeeModel>();

            EmployeeModel obj = new EmployeeModel();
            obj.EmpId = 1;
            obj.EmpName = "Lakshmi";
            obj.EmpSalary = 2310000;

            EmployeeModel obj1 = new EmployeeModel();
            obj1.EmpId = 2;
            obj1.EmpName = "Namrata";
            obj1.EmpSalary = 4310000;

            EmployeeModel obj2 = new EmployeeModel();
            obj2.EmpId = 3;
            obj2.EmpName = "vamshi";
            obj2.EmpSalary = 4310000;

            listemployee.Add(obj);
            listemployee.Add(obj1);
            listemployee.Add(obj2);

            return Json(listemployee, JsonRequestBehavior.AllowGet);
        }

        public FileResult getmeFile()
        {

            return File("~/Web.config", "text/plain");
        }

        public FileResult getmeFile2()
        {

            return File("~/Web.config", "application/xml");
        }
        public FileResult getmeFile3()
        {

            return File("~/ActionResult.pdf", "application/pdf");
        }
        public FileResult getmeFile4()
        {

            return File("~/ActionResult.pdf", "application/pdf", "testDownLoad");
        }

        public ContentResult getmeDifferentContent(int? id)
        {
            if (id == 1)
            {
                return Content("hello World");
            }
            else if (id == 2)
            {
                return Content("<p style=color:red>hello World</p>");
            }
            else
            {
                return Content("<script>alert('hello  world')</script>");
            }
        }

        public RedirectToRouteResult RedirectMyDen() {

            return RedirectToRoute("Default1");
        }
        public RedirectToRouteResult RedirectMyDen2()
        {
            return RedirectToAction("MyfavoriteDay4");
        }
        public RedirectToRouteResult RedirectMyDen3()
        {
            return RedirectToAction("index","Default",new {id=1});
        }

        public ActionResult MyView()
        {
            return View();
        }
    }

}


