using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataBaseFirstApproach.Models
{
    public class EmployeeAndDepart
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public Nullable<int> EmpSalary { get; set; }
        public Nullable<int> DeptId { get; set; }
        public string DepartName { get; set; }

    }
}