using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestCodingProject.Dal
{
    public class Employee
    {
        int employeeID;
        string employeeLastName;
        string employeeFisrtName;
        string employeePhone;
        string employeeZip;
        DateTime hireDate;

        public int EmployeeID { get => employeeID; set => employeeID = value; }
        public string EmployeeLastName { get => employeeLastName; set => employeeLastName = value; }
        public string EmployeeFisrtName { get => employeeFisrtName; set => employeeFisrtName = value; }
        public string EmployeePhone { get => employeePhone; set => employeePhone = value; }
        public string EmployeeZip { get => employeeZip; set => employeeZip = value; }
        public DateTime HireDate { get => hireDate; set => hireDate = value; }

    }
}