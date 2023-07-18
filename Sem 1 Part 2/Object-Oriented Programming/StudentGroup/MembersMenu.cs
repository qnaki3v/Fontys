namespace StudentGroup
{
    using System.Data;
    using System.Data.SqlClient;
    public partial class MembersMenu : Form
    {
        private ProjectGroup projectGroup;
        public MembersMenu(ProjectGroup projectGroup)
        {
            InitializeComponent();
            this.projectGroup = projectGroup;
            
        }

        private void btnShowMembers_Click(object sender, EventArgs e)
        {
            RefreshListBox();
        }

        private void btnAddMember_Click(object sender, EventArgs e)
        {
            AddMemberForm addForm = new AddMemberForm(projectGroup);
            addForm.Show();
        }

        private void btnRemoveMember_Click(object sender, EventArgs e)
        {
            Member member = projectGroup.Members.First(m => m.Id == int.Parse(lbMembers.SelectedItem.ToString().Split(":")[0]));
            projectGroup.RemoveMember(member);
            try
            {
                using (SqlConnection conn = DBConnection.CreateConnection())
                {
                    string sql = $"DELETE FROM Member WHERE StudentNumber = {member.Id}";
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
        private void RefreshListBox()
        {
            lbMembers.Items.Clear();
            try
            {
                using (SqlConnection conn = DBConnection.CreateConnection())
                {
                    string sql = $"SELECT * FROM [Member] WHERE ProjectGroupId = {projectGroup.Id} ORDER BY StudentNumber";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    conn.Open();

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        int studentNumber1 = reader.GetInt32("StudentNumber");
                        string name1 = reader.GetString("Name");
                        int projectGroupId1 = reader.GetInt32("ProjectGroupId");

                        lbMembers.Items.Add(studentNumber1 + ": " + name1);
                        Member member = new Member(studentNumber1, name1, projectGroupId1);
                        projectGroup.AddMember(member);
                    }
                    conn.Close();
                }
                if (lbMembers.Items.Count == 0)
                {
                    MessageBox.Show("No members");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}