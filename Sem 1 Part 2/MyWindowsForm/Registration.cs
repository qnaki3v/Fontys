namespace MyWindowsForm
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "")
            {
                lblNameDisplayed.Text = "Hello " + txtName.Text;
            }
            else
            {
                lblNameDisplayed.Text = "You didn't enter a name";
            }
            if (radioBtnMale.Checked)
            {
                lblGenderDisplayed.Text = "You are a Male";
            }
            else if (radioBtnFemale.Checked)
            {
                lblGenderDisplayed.Text = "You are a Female";
            }
            else
            {
                lblGenderDisplayed.Text = "You didn't select a gender";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            radioBtnMale.Checked = false;
            radioBtnFemale.Checked = false;
            lblNameDisplayed.Text = "Named to be displayed";
            lblGenderDisplayed.Text = "Gender to be displayed";
        }
    }
}