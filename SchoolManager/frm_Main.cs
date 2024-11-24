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
    public partial class frm_Main : Form
    {

        public frm_Main()
        {
            InitializeComponent();
        }


        private void frm_Main_Load(object sender, EventArgs e)
        {
            frm_login login = new frm_login();
            login.ShowDialog();
        }

        private void capturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
                frm_Captura ventanaCaptura = new frm_Captura();
                ventanaCaptura.Show();
             
            
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Consultas ventanaConsultar = new frm_Consultas();
            ventanaConsultar.Show();
        }

        private void alumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Alumnos ventanaAlumnos = new frm_Alumnos();
            ventanaAlumnos.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void capturaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_Captura ventanaCaptura = new frm_Captura();
            ventanaCaptura.Show();
        }

        private void consultaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_Consultas ventanaConsultar = new frm_Consultas();
            ventanaConsultar.Show();
        }

        private void alumnosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_Alumnos ventanaAlumnos = new frm_Alumnos();
            ventanaAlumnos.Show();
        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void adminsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_MainAdmins ventanaAdmins = new frm_MainAdmins();
            ventanaAdmins.Show();
        }
    }
}
