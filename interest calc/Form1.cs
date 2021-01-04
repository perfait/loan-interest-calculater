using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace interest_calc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            double principal = Convert.ToDouble(principalText.Text);
            double rate = Convert.ToDouble(rateText.Text);
            double time= Convert.ToDouble(timeText.Text);

            if(radioButton1.Checked)
                {
                    MessageBox.Show("interest: " + Convert.ToString(principal * rate * time / 100));
                }
           else if (radioButton2.Checked)
            {
                MessageBox.Show("interest: " + Convert.ToString(principal * Math.Pow(1 + rate / 100, time) - principal));
            }
        }
    }
}
