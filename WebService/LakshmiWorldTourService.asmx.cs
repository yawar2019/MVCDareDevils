using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;
using WebService.Model;

namespace WebService
{
    /// <summary>
    /// Summary description for LakshmiWorldTourService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class LakshmiWorldTourService : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }
        [WebMethod]
        public int add(int a,int b)
        {
        return a + b;
        }
        [WebMethod]

        public List<EmployeeModel> getEmployees()
        {
            SqlConnection con = new SqlConnection("Data Source=AZAM-PC\\SQLEXPRESS;Initial Catalog=Employee;Integrated Security=true");

            List<EmployeeModel> listObj = new List<EmployeeModel>();
            SqlCommand cmd = new SqlCommand("usp_getEmployeeDetails", con);
            cmd.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                EmployeeModel obj = new EmployeeModel();
                obj.EmpId = Convert.ToInt32(dr[0]);
                obj.EmpName = Convert.ToString(dr[1]);
                obj.EmpSalary = Convert.ToInt32(dr[2]);
                listObj.Add(obj);
            }
            return listObj;
        }

    }
}
