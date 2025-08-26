using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryVargasSP1PorResolver
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //El boton te lleva de un formulario a otro
            frmBienvenido frmBienvenido = new frmBienvenido();
            frmBienvenido.ShowDialog();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //Aca limpiamos las cajas de texto
            txtUsuario.Text = "";

            txtContraseña.Text = "";

            //Selecciona la opcion -1 ya que no hay opcion ahi
            lstModulo.SelectedIndex = -1;
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
            //el if valida que se escriba la contraseña para activar la lista desplegable
            if (txtContraseña.Text == "")
            {
                lstModulo.Enabled = false;
            }
            else
            {
                lstModulo.Enabled = true;
            }
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            //el if valida que usuario tenga caracteres para habilitar el txtcontraseña
            if (txtUsuario.Text == "")
            {
                txtContraseña.Enabled = false;
            }
            else
            {
                txtContraseña.Enabled = true;
            }
        }

        private void lstModulo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //el if valida que se seleccione algo en la lista para habilitar el boton aceptar
            if (lstModulo.SelectedIndex > -1 && lstModulo.SelectedIndex < 4)
            {
                btnAceptar.Enabled = true;
            }
            else
            {
                btnAceptar.Enabled = false;
            }
        }
    }
}
