﻿using App1.Forms;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App1
{
    public partial class Login : MaterialForm
    {
        public static string[] users = { "Asley", "Silvia" };
        public static string[] pass = { "116850308" };
        public Login()
        {
            InitializeComponent();
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            var pass= materialTextBox22.Text;
            var user = materialTextBox21.Text;
            if(Array.Exists(Login.users, u => u == user))
            {
                if(Array.Exists(Login.pass, u => u == pass))
                {
                    var frm = new Form1();
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("contra incorrecto");
                }
            }
            else
            {
                MessageBox.Show("No existe user");
            }
            
        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {
            var frm = new CrearCuenta();
            frm.Show();
            this.Hide();
        }

        private void materialTextBox22_Click(object sender, EventArgs e)
        {

        }

        private void materialTextBox21_Click(object sender, EventArgs e)
        {

        }
    }
}
