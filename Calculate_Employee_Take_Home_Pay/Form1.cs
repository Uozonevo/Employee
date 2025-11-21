using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ECE2310_HW7_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double totalWeekSales = Convert.ToDouble(textBox2.Text);
            double pay = totalWeekSales * 0.07;
            double federalTaxRate = pay * 0.18;
            double retirementContribution = pay * 0.15;
            double socialSecurityTax = pay * 0.09;

            if (totalWeekSales < 0)
            {
                MessageBox.Show("Total weekly sales must be a positive dollar amount. Please re-enter");
            }
            else
            {
                textBox3.Text = Convert.ToString(federalTaxRate);
                textBox4.Text = Convert.ToString(retirementContribution);
                textBox5.Text = Convert.ToString(socialSecurityTax);

                double netPay = pay - (federalTaxRate + retirementContribution + socialSecurityTax);
                textBox6.Text = Convert.ToString(netPay);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
