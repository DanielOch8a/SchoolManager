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
    public partial class frm_AgregarAdmins : Form
    {
        public frm_AgregarAdmins()
        {
            InitializeComponent();
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtClave.Text == "" || txtNombre.Text == "" || txtDireccion.Text == "" || txtContrasena.Text == "")
            {
                MessageBox.Show("Le faltan datos, por favor llene todos los campos.");
            }
            else
            {
                CConexionBD baseDatos = new CConexionBD();

                DataTable dt = new DataTable();

                try
                {
                    dt = baseDatos.ConsultaTabla("Select * from Usuarios where Clave = " + txtClave.Text);
                }
                catch (Exception)
                {
                }

                if (dt.Rows.Count != 0)
                {
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    MessageBox.Show("Ya hay una clave igual registrada.", "ADVERTENCIA", buttons, MessageBoxIcon.Warning);
                }
                else
                {
                    baseDatos.Instruccion("Insert into Usuarios (Clave,Nombre,Direccion,Contrasena) values('" + txtClave.Text + "','" + txtNombre.Text + "','" + txtDireccion.Text + "','" + txtContrasena.Text + "')");
                    MessageBox.Show("Administrador agregado\ncon exito.");
                    Limpiar();
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

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
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
