using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace TestCodingProject.DataLayer
{
    public class SqlEmployee
    {
        public static string conString = "Data Source=SALCVDEV6\\SQLEXPRESS;Initial Catalog=TestProjectDataBase;Integrated Security=True";
        SqlConnection con = new SqlConnection(conString);

        public void insertEmployee(Dal.Employee employee) {
            con.Open();
            string sqlQueryInsert = "insert into Employee(employeeLastName,employeeFisrtName,employeePhone,employeeZip,hireDate)" +
                "values('" + employee.EmployeeLastName.ToString() + "','" + employee.EmployeeFisrtName.ToString() + "','"+ employee.EmployeePhone.ToString() + "','"+ employee.EmployeeZip.ToString() + "','"+ employee.HireDate +"'); ";
            SqlCommand cmd = new SqlCommand(sqlQueryInsert, con);
            cmd.ExecuteNonQuery();
        }

        public SqlDataReader readEmployee() {
            string sqlQuerySelect = "select * from Employee order by hireDate ASC";
            con.Open();
            SqlCommand cmd = new SqlCommand(sqlQuerySelect, con);
            return cmd.ExecuteReader();
        }
    }
}