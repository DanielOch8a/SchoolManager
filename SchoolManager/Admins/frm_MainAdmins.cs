using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace SchoolManager
{
    public partial class frm_MainAdmins : Form
    {
        public frm_MainAdmins()
        {
            InitializeComponent();

        }

        private void frm_MainAdmins_Load(object sender, EventArgs e)
        {
            CConexionBD baseDatos = new CConexionBD();
            dgv_Usuarios.DataSource = baseDatos.ConsultaTabla("Select * from Usuarios Order By Clave ");
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_AgregarAdmins ventanaAgregarAdmin = new frm_AgregarAdmins();
            ventanaAgregarAdmin.Show();
        }

        private void btnActualizarTabla_Click(object sender, EventArgs e)
        {
            CConexionBD baseDatos = new CConexionBD();
            dgv_Usuarios.DataSource = baseDatos.ConsultaTabla("Select * from Usuarios Order By Clave ");
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_ConsultarAdmins ventanaConsultarAdmins = new frm_ConsultarAdmins();
            ventanaConsultarAdmins.Show();
        }

        private void actualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_ActualizarAdmins ventanaActuAdmins = new frm_ActualizarAdmins();
            ventanaActuAdmins.Show();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_EliminarAdmins ventanaEliminar = new frm_EliminarAdmins();
            ventanaEliminar.Show();
        }
    }
}
