using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using TestCodingProject.Dal;

namespace TestCodingProject.DataLayer
{
    public class EmployeeFacade
    {
        SqlEmployee sqlEmployee = new SqlEmployee();

        /// <summary>
        /// This method inserts employee in the database
        /// </summary>
        public void insertEmployee(Employee employee) {
            sqlEmployee.insertEmployee(employee);
        }

        /// <summary>
        /// This method gets all the employees
        /// </summary>
        public SqlDataReader selectEmployee() {
            return sqlEmployee.readEmployee();
        }

    }
}