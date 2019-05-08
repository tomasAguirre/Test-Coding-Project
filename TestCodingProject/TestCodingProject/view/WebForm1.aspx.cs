using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TestCodingProject.DataLayer;

namespace TestCodingProject.view
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        { //show the data 
            EmployeeFacade employeeFacade = new EmployeeFacade();
            GridView1.DataSource = employeeFacade.selectEmployee();
            GridView1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            EmployeeFacade employeeFacade = new EmployeeFacade();

            Dal.Employee employee = new Dal.Employee();
            employee.EmployeeFisrtName = Text1.Value;
            employee.EmployeeLastName = Text2.Value;
            employee.EmployeePhone = Text3.Value;
            employee.EmployeeZip = Text4.Value;
            employee.HireDate = Calendar1.SelectedDate;

            try
            {
                employeeFacade.insertEmployee(employee);
                //reload the page
                Page.Response.Redirect(Page.Request.Url.ToString(), true);
                Response.Write("everything went ok"); 
            }
            catch {
                Response.Write("an error happened");
            }
            
        }

    }
}