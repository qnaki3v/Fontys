using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week_12___Snackbar
{
    public partial class EditForm : Form
    {
        public Snack Snack { get; set; }
        public ListBox ListBox { get; set; }
        public EditForm(Snack snack, ListBox listBox)
        {
            InitializeComponent();
            tbName.Text = snack.GetName();
            tbPrice.Text = snack.GetPrice();
            tbAmount.Text = snack.GetAmountInStock();
            Snack = snack;
            ListBox= listBox;
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            ListBox.Items.Remove(Snack);
            ListBox.Items.Add(new Snack(tbName.Text, double.Parse(tbPrice.Text), int.Parse(tbAmount.Text)));       
            Close();
        }
    }
}
