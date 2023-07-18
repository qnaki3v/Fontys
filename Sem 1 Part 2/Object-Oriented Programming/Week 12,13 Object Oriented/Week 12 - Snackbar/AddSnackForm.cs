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
    public partial class AddSnackForm : Form
    {
        public Snack Snack { get; set; }
        public ListBox lbSnacks;
        public AddSnackForm(ListBox lbSnacks)
        {
            InitializeComponent();
            this.lbSnacks = lbSnacks;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Snack = new Snack(tbName.Text, double.Parse(tbPrice.Text), int.Parse(tbAmount.Text));
            lbSnacks.Items.Add(Snack);
            Close();
        }
    }
}
