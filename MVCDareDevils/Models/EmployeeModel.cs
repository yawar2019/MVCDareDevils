using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace MVCDareDevils.Models
{
    public class EmployeeModel
    {
        public int EmpId { get; set; }
        [DisplayName("Employee Name")]
       
        public string EmpName { get; set; }
       
        [ScaffoldColumn(false)]
        public int EmpSalary { get; set; }
        public bool status { get; set; }

    }
}