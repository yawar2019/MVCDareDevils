using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace AdoDotnetExample.Models
{
    public class EmployeeContext
    {
        SqlConnection con = new SqlConnection("Data Source=AZAM-PC\\SQLEXPRESS;Initial Catalog=Employee;Integrated Security=true");

        public List<EmployeeModel> getEmployees() {

            List<EmployeeModel> listObj = new List<EmployeeModel>();
            SqlCommand cmd = new SqlCommand("usp_getEmployeeDetails", con);
            cmd.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                EmployeeModel obj = new EmployeeModel();
                obj.EmpId =Convert.ToInt32(dr[0]);
                obj.EmpName = Convert.ToString(dr[1]);
                obj.EmpSalary = Convert.ToInt32(dr[2]);
                listObj.Add(obj);
            }
            return listObj;
        }

        public int SaveEmployee(EmployeeModel emp)
        {
            SqlCommand cmd = new SqlCommand("sp_RajaAddEmployee", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            cmd.Parameters.AddWithValue("@EmpName",emp.EmpName);
            cmd.Parameters.AddWithValue("@EmpSalary",emp.EmpSalary);
           
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }

        

      

        public EmployeeModel GetEmployeeById(int? Id)
        {

            EmployeeModel obj = new EmployeeModel();
            SqlCommand cmd = new SqlCommand("sp_RajagetEmployeeById", con);
            cmd.Parameters.AddWithValue("@EmpId", Id);
            cmd.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                obj.EmpId = Convert.ToInt32(dr[0]);
                obj.EmpName = Convert.ToString(dr[1]);
                obj.EmpSalary = Convert.ToInt32(dr[2]); 
            }
            return obj;
        }

        public int UpdateEmployee(EmployeeModel emp)
        {
            SqlCommand cmd = new SqlCommand("sp_RajaUpdateEmployee", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            cmd.Parameters.AddWithValue("@EmpId", emp.EmpId);
            cmd.Parameters.AddWithValue("@EmpName", emp.EmpName);
            cmd.Parameters.AddWithValue("@EmpSalary", emp.EmpSalary);

            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }

        public int DeleteEmployee(int? Id)
        {
            SqlCommand cmd = new SqlCommand("sp_RajaDeleteEmployee", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            cmd.Parameters.AddWithValue("@EmpId", Id);
      
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }
   
    }
}