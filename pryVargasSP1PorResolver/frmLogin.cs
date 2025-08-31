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
        private int Intentos = 0; //variable contador para validar cantidad de intentos
        public frmLogin()
        {
            InitializeComponent();
        }
        

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //El boton te lleva de un formulario a otro, primero validando que los datos son correctos

            if (txtUsuario.Text == "Adm" && txtContraseña.Text == "1@" && (lstModulo.SelectedIndex == 0 || lstModulo.SelectedIndex == 2 || lstModulo.SelectedIndex == 3))
            {
                Intentos = 0;
                frmBienvenido frmbienvenido = new frmBienvenido();
                frmbienvenido.ShowDialog();
            }
            else if (txtUsuario.Text == "John" && txtContraseña.Text == "*2b" && lstModulo.SelectedIndex == 1)
            {
                Intentos = 0;
                frmBienvenido frmbienvenido = new frmBienvenido();
                frmbienvenido.ShowDialog();
            }
            else if (txtUsuario.Text == "Ceci" && txtContraseña.Text == "*@3c" && (lstModulo.SelectedIndex == 0 || lstModulo.SelectedIndex == 3))
            {
                Intentos = 0;
                frmBienvenido frmbienvenido = new frmBienvenido();
                frmbienvenido.ShowDialog();
            }
            else if (txtUsuario.Text == "God" && txtContraseña.Text == "*@#4d" && (lstModulo.SelectedIndex == 0 || lstModulo.SelectedIndex == 1 || lstModulo.SelectedIndex == 2 || lstModulo.SelectedIndex == 3))
            {
                Intentos = 0;
                frmBienvenido frmbienvenido = new frmBienvenido();
                frmbienvenido.ShowDialog();
            }
            else
            {
                MessageBox.Show("Usuario y/o contraseña incorrectos para el módulo seleccionado");
                Intentos++;
                if (Intentos == 3)
                {
                    this.Close(); //cierra el formulario
                }
            }
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
