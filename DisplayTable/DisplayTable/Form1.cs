using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DisplayTable
{
    public partial class DisplayTableForm : Form
    {
        private consultantDataContext database = new consultantDataContext();

        public DisplayTableForm()
        {
            InitializeComponent();
        }

        private void DisplayTableForm_Load(object sender, EventArgs e)
        {
            employeeBindingSource.DataSource =
                from employee in database.employees
                orderby employee.empID
                select employee;

            divisionBindingSource.DataSource =
               from division in database.divisions
               orderby division.did
               select division;

            projectBindingSource.DataSource =
              from project in database.projects
              orderby project.did
              select project;

            workonBindingSource.DataSource =
              from workon in database.workons
              orderby workon.pid
              select workon;

        }
    }
}
