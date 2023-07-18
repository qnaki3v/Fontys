using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentGroup
{
    public partial class ProjectGroupsMenu : Form
    {
        private List<ProjectGroup> projectsGroups;

        public ProjectGroupsMenu()
        {
            InitializeComponent();
            projectsGroups = new List<ProjectGroup>();
            RefreshListBox();
        }
        public List<ProjectGroup> ProjectsGroups
        { 
            get { return projectsGroups; }
            set { projectsGroups = value; }
        }
        private void btnAddGroupProject_Click(object sender, EventArgs e)
        {
            AddProjectGroupForm addProjectGroupForm = new AddProjectGroupForm(this);
            addProjectGroupForm.Show();
        }

        public void AddProjectGroup(ProjectGroup projectGroup)
        {
            projectsGroups.Add(projectGroup);
            RefreshListBox();
        }
        

        private void btnSelectProjectGroup_Click(object sender, EventArgs e)
        {
            if (lbGroupProjects.SelectedIndex > -1)
            {
                ProjectGroup projectGroup = projectsGroups.First(pg => pg.Id == int.Parse(lbGroupProjects.SelectedItem.ToString().Split(":")[0])); // gives the reference to the project group with the same id
                MembersMenu membersMenu = new MembersMenu(projectGroup);
                membersMenu.Show();
                
            }
            else 
            {
                MessageBox.Show("Nothing selected");
            }
        }
        private void btnDeleteProjectGroup_Click(object sender, EventArgs e)
        {
            ProjectGroup projectGroup = projectsGroups.First(pg => pg.Id == int.Parse(lbGroupProjects.SelectedItem.ToString().Split(":")[0]));
            projectsGroups.Remove(projectGroup);
            try
            {
                using (SqlConnection conn = DBConnection.CreateConnection())
                {
                    string sql = $"DELETE FROM ProjectGroup WHERE Id = {projectGroup.Id}";
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
            RefreshListBox();
        }

        public void RefreshListBox()
        {
            lbGroupProjects.Items.Clear();
            try
            {
                using (SqlConnection conn = DBConnection.CreateConnection())
                {
                    string sql = "SELECT * FROM [ProjectGroup] ORDER BY Id";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    conn.Open();

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        int id1 = reader.GetInt32("Id");
                        string name1 = reader.GetString("Name");

                        lbGroupProjects.Items.Add(id1 + ": " + name1);
                        ProjectsGroups.Add(new ProjectGroup(id1, name1));

                    }
                    conn.Close();
                }
                if (lbGroupProjects.Items.Count == 0)
                {
                    MessageBox.Show("No project groups");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
