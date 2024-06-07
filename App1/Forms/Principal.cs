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

namespace App1.Forms
{

    public partial class Principal : MaterialForm
    {
        string[] Vproductos = { };
        int[] VunidadesCompra = { };
        double[] VprecioUnitario = { };
        double[] Vtotal = { };
        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void txtPrecioUnitario_Leave(object sender, EventArgs e)
        {

            int precioUnitario =Convert.ToInt32(txtPrecioUnitario.Text);
            int unidadesCompradas =Convert.ToInt32(slideUnidades.Value);
            txtTotal.Text = "" + precioUnitario * unidadesCompradas;
            
        }

        private void slideUnidades_onValueChanged(object sender, int newValue)
        {

            int precioUnitario = Convert.ToInt32(txtPrecioUnitario.Text);
            int unidadesCompradas = Convert.ToInt32(slideUnidades.Value);
            txtTotal.Text = "" + precioUnitario * unidadesCompradas;
        }

        private void btnProcesarCompra_Click(object sender, EventArgs e)
        {
            string nombreProducto = txtProducto.Text;
            int unidades = Convert.ToInt32(slideUnidades.Value);
            double precioUnitario = Convert.ToDouble(txtPrecioUnitario.Text);
            double total = Convert.ToDouble(txtTotal.Text);

            if (total<= 0 || unidades<=0 || precioUnitario<=0)
            {

                MessageBox.Show("Los valores no pueden ser cero");
            }
            else
            {
                if (string.IsNullOrEmpty(nombreProducto))
                {
                    MessageBox.Show("nombre del producto no debe ser vacio");
                }
                else
                {
                    Array.Resize(ref Vproductos, Vproductos.Length + 1);
                    Array.Resize(ref VunidadesCompra, VunidadesCompra.Length + 1);
                    Array.Resize(ref VprecioUnitario, VprecioUnitario.Length + 1);
                    Array.Resize(ref Vtotal, Vtotal.Length + 1);

                    Vproductos[Vproductos.Length -1] = nombreProducto;
                    VunidadesCompra[VunidadesCompra.Length - 1] = unidades;
                    VprecioUnitario[VprecioUnitario.Length - 1] = precioUnitario;
                    Vtotal[Vtotal.Length - 1] += total;

                    txtPrecioUnitario.Text = "";
                    txtProducto.Text = "";
                    txtTotal.Text = "0.0";
                    slideUnidades .Value = 0;
                    MessageBox.Show("Compra efectuada con exito");
                    txtProducto.Focus();

                }
            }
        }
    }
}
