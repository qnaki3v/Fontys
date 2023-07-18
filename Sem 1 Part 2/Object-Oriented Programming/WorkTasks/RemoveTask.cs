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
    public partial class RemoveTask : Form
    {
        Company company;
        public RemoveTask(Company company)
        {
            InitializeComponent();
            this.company = company;
            lbTasksToRemove.Items.Clear();
            foreach (var task in company.Tasks.Where(t => t.Status == "Open" && t.EmployeesAssigned.Count == 0))
            {
                lbTasksToRemove.Items.Add(task);
            }
        }

        private void btnRemoveTask_Click(object sender, EventArgs e)
        {
            CompanyTask toBeRemoved = (CompanyTask)lbTasksToRemove.SelectedItem;
            company.Tasks.Remove(toBeRemoved);
            lbTasksToRemove.Items.Remove(lbTasksToRemove.SelectedItem);
        }
    }
}
