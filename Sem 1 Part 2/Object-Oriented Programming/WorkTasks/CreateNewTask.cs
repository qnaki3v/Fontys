using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkTasks
{
    public partial class CreateNewTask : Form
    {
        Company company;
        public CreateNewTask(Company company)
        {
            InitializeComponent();
            this.company = company;
        }

        private void btnCreateTask_Click(object sender, EventArgs e)
        {
            string title = tbTitle.Text;
            string status = "";
            if (rBtnInProgress.Checked)
            {
                status = "In Progress";
            }
            else if (rBtnCompleted.Checked)
            {
                status = "Completed";
            }
            else if (rBtnOpen.Checked)
            {
                status = "Open";
            }
            else if (rBtnBlocked.Checked)
            {
                status = "Blocked";
            }
            else if (rBtnCancelled.Checked)
            {
                status = "Cancelled";
            }
            DateTime deadline = dtPDeadline.Value;
            string? author = tbAuthor.Text;
            string description = tbDescription.Text;
            CompanyTask companyTask = new CompanyTask(title, status, deadline, author, description);

            if (cbxResearchDevelopment.Checked)
            {
                companyTask.Departments.Add("Research and Development");
            }
            if (cbxMarketing.Checked)
            {
                companyTask.Departments.Add("Marketing");
            }
            if (cbxHumanResources.Checked)
            {
                companyTask.Departments.Add("Human Resources");
            }
            if (cbxSupport.Checked)
            {
                companyTask.Departments.Add("Support");
            }
            if (cbxSales.Checked)
            {
                companyTask.Departments.Add("Sales");
            }

            company.Tasks.Add(companyTask);
            Close();
        }
    }
}
