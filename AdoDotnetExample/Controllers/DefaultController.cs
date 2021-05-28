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
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        //[HttpPost]
        //public ActionResult Create(string EmpName,int EmpSalary)
        //{
        //    return View();
        //}

        [HttpPost]
        public ActionResult Create(EmployeeModel emp)
        {
            int i = db.SaveEmployee(emp);
            if (i > 0)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }

        //[HttpPost]
        //public ActionResult Create(FormCollection frm)
        //{
        //    string EmpName = frm["EmpName"];
        //    return View();
        //}



        [HttpGet]
        public ActionResult Edit(int? id)
        {
            return View();
        }

    }
}