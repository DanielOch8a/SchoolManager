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
    public partial class frm_login : Form
    {
        public frm_login()
        {
            InitializeComponent();
        }

        bool seIniciaraSesion = false;

        private void btn_Iniciar_Click(object sender, EventArgs e)
        {
            if (txtClave.Text != "" || txtContrasena.Text != "")
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
                    if (txtClave.Text == (dt.Rows[0][0]).ToString() && txtContrasena.Text == dt.Rows[0][3].ToString())
                    {
                        seIniciaraSesion = true;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Contraseña incorrecta.");
                    }
                }
                else
                {
                    MessageBox.Show("No se ha encontrado el registro.");
                }
            }
            else
            {
                MessageBox.Show("Por favor llene todos los campos.");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frm_login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (seIniciaraSesion != true)
            {
                if (e.CloseReason == CloseReason.UserClosing)
                {
                    e.Cancel = true;
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
