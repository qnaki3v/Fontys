using System.Data;
using System.Data.SqlClient;

namespace DatabaseConnect
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = DBConnection.CreateConnection())
                {
                    string sql = "SELECT * FROM [user] ORDER BY id";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    conn.Open();

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        int id1 = reader.GetInt32("id");
                        string username1 = reader.GetString("username");
                        string email1 = reader.GetString("email");

                        lbShow.Items.Add(id1 + ": " + username1 + " - " + email1);
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}