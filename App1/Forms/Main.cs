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
        string[] names = new string[3];
        int[] units = new int[3];
        double[] prices = new double[3];
        double[] totals = new double[3];
        private void materialButton1_Click(object sender, EventArgs e)
        {
            var name= materialTextBox21.Text;
            int unit = materialSlider1.Value;
            double price = Double.Parse(materialTextBox22.Text);
            double total = Double.Parse(materialTextBox23.Text);
        }
    }
}
