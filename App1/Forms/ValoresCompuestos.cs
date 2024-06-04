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
    public partial class ValoresCompuestos : Form
    {
        public ValoresCompuestos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine(sexo[0]);
            sexo[0] = "a";
            Console.WriteLine(sexo[0]);
        }
        string[] sexo = {
            "hombre"
        };
        string[] cars = new string[100];
        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.Items.AddRange(sexo);
        }
        int i = 0;
        private void ValoresCompuestos_Load(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cars[i++] = textBox1.Text;
            label2.Text = i + "";
            
        }
      
        private void button4_Click(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            Array.Resize(ref cars, i);
            Array.Sort(cars);
            comboBox2.Items.AddRange(cars);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Array.Resize(ref cars, i);
            Array.Sort(cars);
            Array.Reverse(cars);
            comboBox2.Items.Clear();
            comboBox2.Items.AddRange(cars);
        }
    }
}
