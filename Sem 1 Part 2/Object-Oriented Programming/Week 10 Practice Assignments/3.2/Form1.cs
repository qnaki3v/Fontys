namespace _3._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnColorChange_Click(object sender, EventArgs e)
        {
            if (BackColor == Color.Red)
            {
                BackColor = Color.Green;
            }
            else if (BackColor == Color.Green)
            {
                BackColor = Color.Blue;
            }
            else
            {
                BackColor = Color.Red;
            }
        }
    }
}