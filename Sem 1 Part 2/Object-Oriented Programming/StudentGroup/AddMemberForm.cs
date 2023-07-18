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
    public partial class AddMemberForm : Form
    {
        ProjectGroup projectGroup;
        public AddMemberForm(ProjectGroup projectGroup)
        {
            InitializeComponent();
            this.projectGroup = projectGroup;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Member member = new Member(tbName.Text, projectGroup.Id);
            if (projectGroup.Members.Count == 0)
            {
                member.Id = 1;
            }
            else
            {
                member.Id = projectGroup.Members.Last().Id + 1;
            }
            try
            {
                using (SqlConnection conn = DBConnection.CreateConnection())
                {
                    string sql = $"INSERT INTO Member(Name, ProjectGroupId) VALUES ('{member.Name}', {projectGroup.Id});";
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
            projectGroup.AddMember(member);
            Close();
        }
    }
}
