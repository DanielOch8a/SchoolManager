using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManager
{
    public partial class frm_ActualizarAdmins : Form
    {
        public frm_ActualizarAdmins()
        {
            InitializeComponent();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

            if (txtClave.Text == "" || txtNombre.Text == "" || txtDireccion.Text == "" || txtContrasena.Text == "")
            {
                MessageBox.Show("Le faltan datos, por favor llene todos los campos.");
            }
            else
            {
                CConexionBD baseDatos = new CConexionBD();
                try
                {
                    baseDatos.Instruccion("Update Usuarios set Nombre='" + txtNombre.Text + "', Direccion='" + txtDireccion.Text + "', Contrasena='" + txtContrasena.Text + "' where Clave =" + txtClave.Text);
                    Limpiar();
                }
                catch (Exception)
                {
                    MessageBox.Show("No se encontro algun registro con clave: "+txtClave.Text);
                    
                }
                
            }

        }

        public void Limpiar()
        {
            txtClave.Text = null;
            txtNombre.Text = null;
            txtDireccion.Text = null;
            txtContrasena.Text = null;
        }

        private void txtClave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
