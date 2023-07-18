namespace Week_12___Snackbar
{
    public partial class Form1 : Form
    {
        SnackBar snackBar;
        public Form1()
        {
            snackBar = new SnackBar(new Snack("Chocolate", 2, 10), 
                                             new Snack("Soda", 1.5, 10), 
                                             new Snack("Chips", 3, 20));
            InitializeComponent();
            lbSnacks.Items.Clear();
            foreach(Snack snack in snackBar.Snacks)
            {
                lbSnacks.Items.Add(snack);
            }
            
        }

        private void BtnOrder_Click(object sender, EventArgs e)
        {
            double orderPrice = snackBar.ProcessOrder(int.Parse(cbSnackOne.Text), int.Parse(cbSnackTwo.Text), int.Parse(cbSnackThree.Text));
            if (orderPrice > 0)
            {
                snackBar.Revenue += orderPrice;
                MessageBox.Show($"Your order costs {orderPrice:f2}€.");
            }
            else
            {
                switch (orderPrice)
                {
                    case -1:
                        MessageBox.Show("Snack One not in stock. Your order cannot be processed.");
                        break;
                    case -2:
                        MessageBox.Show("Snack Two not in stock. Your order cannot be processed.");
                        break;
                    case -3:
                        MessageBox.Show("Snack Three not in stock. Your order cannot be processed.");
                        break;
                }
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            AddSnackForm add = new AddSnackForm(lbSnacks);
            add.Show();
            snackBar.Snacks.Add(add.Snack);
        }
        private void BtnEdit_Click(object sender, EventArgs e)
        {
            EditForm edit = new EditForm((Snack)lbSnacks.SelectedItem, lbSnacks);
            edit.Show();
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            lbSnacks.Items.Remove(lbSnacks.SelectedItem);
            snackBar.Snacks.Remove((Snack)lbSnacks.SelectedItem);
        }

        
    }
}