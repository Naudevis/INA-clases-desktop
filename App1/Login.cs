using App1.Forms;
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
        public static string[] users = { "admin" };
        public static string[] pass = { "admin" };
        public Login()
        {
            InitializeComponent();
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            string usuarioAutentica = txtUsuario.Text;
            string passwdAutentica = txtContrasennia.Text;


            bool existeUsuario = Array.Exists(users,filtro => filtro == usuarioAutentica);
            bool existeContrasennia = Array.Exists(users, filtro => filtro == passwdAutentica);

            if (existeUsuario && existeContrasennia)

            {
                Principal principal = new Principal();
                principal.Show();
                Visible = false; // oculta la ventana
            }
            else
            {

                MessageBox.Show("Usuario y/o contraseña no coinciden",
                    "Error de acceso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            /*
            var pass= txtContrasennia.Text;
            var user = txtUsuario.Text;
            var frm = new Form1();
            frm.Show();
            this.Hide();*/
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
