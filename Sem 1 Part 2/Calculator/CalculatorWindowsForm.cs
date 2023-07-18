namespace Calculator
{
    public partial class Title : Form
    {
        double firstMemoryNum = 0;
        double secondMemoryNum = 0;
        double resultMemoryNum = 0;
        public Title()
        {
            InitializeComponent();
        }

        private void btnRecallNumOne_Click(object sender, EventArgs e)
        {
            if (txtNumOne.Text == "" && firstMemoryNum != 0)
            {
                txtNumOne.Text = firstMemoryNum.ToString();
                return;
            }
            else if (double.Parse(txtNumOne.Text) != 0)
            {
                firstMemoryNum = double.Parse(txtNumOne.Text);
                return;
            }
        }

        private void btnRecallNumTwo_Click(object sender, EventArgs e)
        {
            if (txtNumTwo.Text == "" && secondMemoryNum != 0)
            {
                txtNumTwo.Text = secondMemoryNum.ToString();
                return;
            }
            else if (double.Parse(txtNumTwo.Text) != 0)
            {
                secondMemoryNum = double.Parse(txtNumTwo.Text);
                return;
            }
        }

        private void btnRecallResult_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "" && resultMemoryNum != 0)
            {
                txtResult.Text = resultMemoryNum.ToString();
                return;
            }
            else if (double.Parse(txtResult.Text) != 0)
            {
                resultMemoryNum = double.Parse(txtResult.Text);
                return;
            }
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {

            if (rbtnAdd.Checked)
            {
                txtResult.Text = (double.Parse(txtNumOne.Text) + double.Parse(txtNumTwo.Text)).ToString();
            }
            else if (rbtnSubtract.Checked)
            {
                txtResult.Text = (double.Parse(txtNumOne.Text) - double.Parse(txtNumTwo.Text)).ToString();
            }
            else if (rbtnMultiply.Checked)
            {
                txtResult.Text = (double.Parse(txtNumOne.Text) * double.Parse(txtNumTwo.Text)).ToString();
            }
            else if (rbtnDevide.Checked)
            {
                txtResult.Text = (double.Parse(txtNumOne.Text) / double.Parse(txtNumTwo.Text)).ToString();
            }
        }
    }
}