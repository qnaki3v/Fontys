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
    public partial class UpdateTask : Form
    {
        Company company;
        public UpdateTask(Company company)
        {
            InitializeComponent();
            this.company = company;
            lbTasksToUpdate.Items.Clear();
            foreach (var task in company.Tasks)
            {
                lbTasksToUpdate.Items.Add(task);
            }
        }

        private void btnUpdateTask_Click(object sender, EventArgs e)
        {
            CompanyTask toBeUpdated = (CompanyTask)lbTasksToUpdate.SelectedItem;
            UpdatingSelectedTask updatingSelectedTask = new UpdatingSelectedTask(company,toBeUpdated);
            updatingSelectedTask.Show();
        }
    }
}
