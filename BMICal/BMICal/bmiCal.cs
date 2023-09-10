using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMICal
{
    public partial class bmiCal : Form
    {
        public bmiCal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double height = double.Parse(txtHeight.Text);
            double weight = double.Parse(txtWwight.Text);

            double bmi = weight / (height);

            txtBMI.Text = bmi.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtHeight.Text = "";
            txtWwight.Text = "";
            txtBMI.Text = "";
        }
    }
}
