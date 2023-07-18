using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentGroup
{
    public partial class AddProjectGroupForm : Form
    {
        private ProjectGroupsMenu projectGroupsMenu;
        public AddProjectGroupForm(ProjectGroupsMenu projectGroupsMenu)
        {
            InitializeComponent();
            this.projectGroupsMenu = projectGroupsMenu;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ProjectGroup projectGroup = new ProjectGroup(tbName.Text);
            if (projectGroupsMenu.ProjectsGroups.Count == 0)
            {
                projectGroup.Id= 1;
            }
            else
            {
                projectGroup.Id = projectGroupsMenu.ProjectsGroups.Last().Id + 1;
            }
            try
            {
                using (SqlConnection conn = DBConnection.CreateConnection())
                {
                    string sql = $"INSERT INTO ProjectGroup(Name) VALUES ('{projectGroup.Name}');";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    conn.Open();

                    SqlDataReader reader = cmd.ExecuteReader();

                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            projectGroupsMenu.AddProjectGroup(projectGroup);
            Close();
            
        }
    }
}
