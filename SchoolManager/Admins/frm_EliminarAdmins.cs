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
    public partial class frm_EliminarAdmins : Form
    {
        public frm_EliminarAdmins()
        {
            InitializeComponent();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtClave.Text != "")
            {
                CConexionBD baseDatos = new CConexionBD();

                DataTable dt = new DataTable();
                try
                {
                    dt = baseDatos.ConsultaTabla("Select * from Usuarios where Clave = " + txtClave.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Clave no encontrada en el sistema.");
                    return;
                }


                if (dt.Rows.Count != 0)
                {
                    baseDatos.Instruccion("Delete Usuarios where Clave =" + txtClave.Text);
                    MessageBox.Show("Se ha eliminado el registro con exito.");
                    txtClave.Text = null;
                }
                else
                {
                    MessageBox.Show("No se ha encontrado el registro.");
                }
            }
            else
            {
                MessageBox.Show("Por favor introduzca una clave.");
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
