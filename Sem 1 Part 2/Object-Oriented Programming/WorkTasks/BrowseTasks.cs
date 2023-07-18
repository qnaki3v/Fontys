using System.Collections.Generic;

namespace WorkTasks
{
    public partial class BrowseTasks : Form
    {
        Company company;
        public BrowseTasks(Company company)
        {
            InitializeComponent();
            this.company = company;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            lbxTasks.Items.Clear();

            if (tbSearchbar.Text == "" &&
                rBtnInProgress.Checked == false &&
                rBtnCompleted.Checked == false &&
                rBtnOpen.Checked == false &&
                rBtnBlocked.Checked == false &&
                rBtnCancelled.Checked == false &&
                cbxResearchDevelopment.Checked == false &&
                cbxMarketing.Checked == false &&
                cbxHumanResources.Checked == false &&
                cbxSupport.Checked == false &&
                cbxSales.Checked == false)
            {
                lbxTasks.Items.Clear();
                foreach (var task in company.Tasks.OrderBy(t => t.Deadline))
                {
                    lbxTasks.Items.Add(task);
                }
            }
            else
            {
                string substring = tbSearchbar.Text;
                string status = "";
                string department = "";
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

                if (cbxResearchDevelopment.Checked)
                {
                    department = "Research and Development";
                }
                else if (cbxMarketing.Checked)
                {
                    department = "Marketing";
                }
                else if (cbxHumanResources.Checked)
                {
                    department = "Human Resources";
                }
                else if (cbxSupport.Checked)
                {
                    department = "Support";
                }
                else if (cbxSales.Checked)
                {
                    department = "Sales";
                }
                //Departments has All departments has needed
                lbxTasks.Items.Clear();

                foreach (var task in company.Tasks.Where(t => t.Title.Contains(substring) && t.Status == status && t.Departments.Contains(department)))
                {
                    lbxTasks.Items.Add(task);
                }
            }
        }
    }
}