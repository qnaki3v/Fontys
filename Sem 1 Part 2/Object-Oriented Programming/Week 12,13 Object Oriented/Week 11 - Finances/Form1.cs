namespace Week_11___Finances
{
    public partial class Form1 : Form
    {
        List<Expense> transactionLog;
        public Form1()
        {
            transactionLog = new List<Expense>();
            InitializeComponent();
            dmnUDAmount.Text = "0";
            dmnUDSameAmount.Text = "0";
        }

        private void btnAddExpense_Click(object sender, EventArgs e)
        {
            Expense expense = new Expense(tbName.Text, double.Parse(dmnUDAmount.Text));
            transactionLog.Add(expense);
        }

        private void btnShowExpenses_Click(object sender, EventArgs e)
        {
            lbTransactionLog.Items.Clear();
            foreach (Expense transaction in transactionLog)
            {
                lbTransactionLog.Items.Add(transaction.GetInfo());
            }
        }

        private void btnSameAmountExpenses_Click(object sender, EventArgs e)
        {
            lbTransactionLog.Items.Clear();
            foreach (Expense transaction in transactionLog)
            {
                if (transaction.Amount == double.Parse(dmnUDSameAmount.Text))
                {
                    lbTransactionLog.Items.Add(transaction.GetInfo());
                }
            }
        }
    }
}