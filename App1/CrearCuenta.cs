using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App1
{
    public partial class CrearCuenta : MaterialForm
    {
        public CrearCuenta()
        {
            InitializeComponent();
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            var pass = materialTextBox22.Text;
            var user = materialTextBox21.Text;
            var frm = new Form1();
            frm.Show();
            this.Dispose();
        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {
            var frm = new Login();
            frm.ShowDialog();  
            this.Dispose();
        }
    }
}
