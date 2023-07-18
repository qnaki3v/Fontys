namespace BMI_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtWeight.Text != "" && txtHeight.Text != "")
            {
                string state;
                double bmi = double.Parse(txtWeight.Text) / Math.Pow(double.Parse(txtHeight.Text),2);
                switch (bmi)
                {
                    case var expression when bmi < 18.5:
                        state = "underweight";
                        break;
                    case var expression when bmi < 25:
                        state = "normal weight";
                        break;
                    case var expression when bmi < 30:
                        state = "overweight";
                        break;
                    default:
                        state = "obese";
                        break;
                }
                label3.Text = "Your bmi is " + bmi.ToString();
                label4.Text = "You are "+ state;
            }
            else
            {
                label3.Text = "Please enter body dimensions";
                label4.Text = "";
            }
        }
    }
}