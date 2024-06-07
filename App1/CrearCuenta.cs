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
            var pass = txtContrasennia.Text;
            var user = txtUsuarioCrear.Text;
            if (user.Equals(""))
            {
                MessageBox.Show("No ingresaste el nombre del usuario");
            }
            else
            {
                if (pass.Equals("")/*txtRepiteContrasennia.Text.Equals("")*/)
                {
                    MessageBox.Show("No ingresaste la contraseña");


                }
                else
                {
                    if (!pass.Equals(pass/*txtRepiteContrasennia*/))
                    {
                        MessageBox.Show("Las contraseñas no coinciden!");

                    }
                    else
                    {
                        //Codigo para empezar a crear el usuario
                        if (Array.Exists(Login.users, u => u == user))
                        {
                            MessageBox.Show("YA existe");
                        }
                        else
                        {
                            Array.Resize(ref Login.users, Login.users.Length + 1);
                            Array.Resize(ref Login.pass, Login.pass.Length + 1);
                            Login.users[Login.users.Length - 1] = user;
                            Login.pass[Login.pass.Length - 1] = pass;
                            MessageBox.Show("Ya se registro");
                            if (
                                MessageBox.Show(
                                    "Alerta",
                                    "Deseas iniciar sesion",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Asterisk
                                    ) == DialogResult.Yes
                            )
                            {
                                var loginFrm =new Login();
                                loginFrm.txtUsuario.Text= user;
                                loginFrm.Show();
                                this.Hide();
                            }
                            else
                            {

                            }
                        }
                    }
                }
            }

            //var frm = new Form1();
            //frm.Show();
            //this.Dispose();
        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {
            var frm = new Login();
            frm.ShowDialog();
            this.Dispose();
        }

        private void materialTextBox21_Click(object sender, EventArgs e)
        {

        }

        private void CrearCuenta_Load(object sender, EventArgs e)
        {

        }
    }
}
