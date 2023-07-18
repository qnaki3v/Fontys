using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WorkTasks
{
    public partial class UpdatingSelectedTask : Form
    {
        Company company;
        CompanyTask companyTask;
        public UpdatingSelectedTask(Company company, CompanyTask companyTask)
        {
            InitializeComponent();
            this.company = company;
            this.companyTask = companyTask;
            if (companyTask.Status == "In Progress")
            {
                rBtnInProgress.Checked = true;
            }
            else if (companyTask.Status == "Completed")
            {
                rBtnCompleted.Checked = true;
            }
            else if (companyTask.Status == "Open")
            {
                rBtnOpen.Checked = true;
            }
            else if (companyTask.Status == "Blocked")
            {
                rBtnBlocked.Checked = true;
            }
            else if (companyTask.Status == "Cancelled")
            {
                rBtnCancelled.Checked = true;               
            }
            lbEmployeesToBeAssigned.Items.Clear();
            foreach (var employee in this.company.Employees.Where(e => this.companyTask.Departments.Contains(e.Department)))
            {
                lbEmployeesToBeAssigned.Items.Add(employee);
            }
        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            Employee employee = (Employee)lbEmployeesToBeAssigned.SelectedItem;
            companyTask.EmployeesAssigned.Add(employee);
            lbEmployeesToBeAssigned.Items.Remove(employee);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            if (rBtnInProgress.Checked)
            {
                companyTask.Status = "In Progress";
            }
            else if (rBtnCompleted.Checked)
            {
                companyTask.Status = "Completed";
            }
            else if (rBtnOpen.Checked)
            {
                companyTask.Status = "Open";
            }
            else if (rBtnBlocked.Checked)
            {
                companyTask.Status = "Blocked";
            }
            else if (rBtnCancelled.Checked)
            {
                companyTask.Status = "Cancelled";
            }
        }

        private void btnUnassign_Click(object sender, EventArgs e)
        {

        }
    }
}
