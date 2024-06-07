using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App1.Forms
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        string[] names = new string[1];
        int[] units = new int[1];
        double[] prices = new double[1];
        double[] totals = new double[1];
        private void materialButton1_Click(object sender, EventArgs e)
        {
            var name= materialTextBox21.Text;
            int unit = materialSlider1.Value;
            double price = Double.Parse(materialTextBox22.Text);
            double total = Double.Parse(materialTextBox23.Text);
            if (total<=0 || unit <= 0 || price <= 0)
            {
                MessageBox.Show("no");
            }
            else
            {
                if(string.IsNullOrEmpty(name))
                {
                    MessageBox.Show("no name");
                }
                else
                {
                    Array.Resize(ref names, names.Length+1);
                    Array.Resize(ref units, units.Length + 1);
                    Array.Resize(ref prices, prices.Length + 1);
                    Array.Resize(ref totals, totals.Length + 1);
                    names[names.Length - 1] = name;
                    units[units.Length - 1]= unit;
                    prices[ prices.Length - 1]= price;
                    totals[ totals.Length - 1]= total;
                    MessageBox.Show("si");
                    dataGridView1.Rows.Add(new object[] {name, unit, price, total});
                }
            }
        }

        private void materialSlider1_onValueChanged(object sender, int newValue)
        {
            int unit = materialSlider1.Value;
            double price = Double.Parse(materialTextBox22.Text);
            materialTextBox23.Text = (price * unit).ToString();
        }

        private void materialTextBox22_Leave(object sender, EventArgs e)
        {
            int unit = materialSlider1.Value;
            double price = Double.Parse(materialTextBox22.Text);
            materialTextBox23.Text = (price * unit).ToString();
        }
    }
}
