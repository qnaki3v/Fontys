namespace Week_12___Lottery
{
    public partial class Form1 : Form
    {
        Lottery lottery;

        public Form1()
        {
            InitializeComponent();
            btnNextNum.Enabled = false;
            btnDrawAllNums.Enabled = false;
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            btnNextNum.Enabled = true;
            btnDrawAllNums.Enabled = true;
            try
            {
                lottery = new Lottery(int.Parse(tbMaxValue.Text), int.Parse(tbNrOfWantedNums.Text));
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid input. You are requesting too much numbers with too low max value.");
            }
            if (int.Parse(tbNrOfWantedNums.Text) <= int.Parse(tbMaxValue.Text))
            {
                lbLotteries.Items.Add(lottery);
            }
        }

        private void BtnNextNum_Click(object sender, EventArgs e)
        {
            if (lottery.IsLotteryFinished())
            {
                MessageBox.Show("Lottery ticket is ready. No more numbers to draw.");
            }
            else
            {
                lottery.DrawNextNumber();
                lbLotteries.Items[lbLotteries.SelectedIndex] = lottery;
            }          
        }

        private void BtnDrawAllNums_Click(object sender, EventArgs e)
        {
            if (lottery.IsLotteryFinished())
            {
                MessageBox.Show("Lottery ticket is ready. No more numbers to draw.");
            }
            else
            {
                lottery.DrawAllNumbers();
                lbLotteries.Items[lbLotteries.SelectedIndex] = lottery;
            }
        }
    }
}