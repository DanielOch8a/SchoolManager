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
    public partial class frm_ConsultarAdmins : Form
    {
        public frm_ConsultarAdmins()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {

            if (txtClave.Text == "")
            {
                MessageBox.Show("Por favor introduzca una clave.");
            }
            else
            {
                CConexionBD baseDatos = new CConexionBD();

                DataTable dt = new DataTable();

                dt = baseDatos.ConsultaTabla("Select * from Usuarios where Clave = " + txtClave.Text);

                if (dt.Rows.Count != 0)
                {
                    txtNombre.Text = dt.Rows[0]["Nombre"].ToString();
                    txtDireccion.Text = dt.Rows[0]["Direccion"].ToString();
                    txtContrasena.Text = dt.Rows[0]["Contrasena"].ToString();
                }
                else
                {
                    MessageBox.Show("No se ha encontrado el registro.");
                }
            }
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
