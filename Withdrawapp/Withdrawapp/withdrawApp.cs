using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Withdrawapp
{
    public partial class withdrawApp : Form
    {
        public withdrawApp()
        {
            InitializeComponent();
        }

        private double balance = 15000;
        private void button1_Click(object sender, EventArgs e)
        {
            double amount = double.Parse(amountTxt.Text);
            if (balance >= amount)
            {
                balance -= amount;
                balanceTxt.Text = "Your Remaining Balance is: " + balance;
            }
            else
            { balanceTxt.Text = "Insufficent Balance"; }
        }
    }
}
