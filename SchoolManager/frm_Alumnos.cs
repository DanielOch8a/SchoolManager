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
    public partial class frm_Alumnos : Form
    {
        public frm_Alumnos()
        {
            InitializeComponent();
        }
        private void cbxAlumnos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxAlumnos.Text == "Arath Camacho")
            {
                txtEdad.Text = "19";
                txtGrupo.Text = "S3A";
                txtCarrera.Text = "Ing. Sistemas";
                txtExtraescolar.Text = "Futbol";
            }
            if (cbxAlumnos.Text == "Daniel Ochoa")
            {
                txtEdad.Text = "20";
                txtGrupo.Text = "S3A";
                txtCarrera.Text = "Ing. Sistemas";
                txtExtraescolar.Text = "BasketBall";
            }
            if (cbxAlumnos.Text == "José Soto")
            {
                txtEdad.Text = "20";
                txtGrupo.Text = "M3B";
                txtCarrera.Text = "Ing. Mecanica";
                txtExtraescolar.Text = "Arte";
            }
            if (cbxAlumnos.Text == "Miguel Fajardo")
            {
                txtEdad.Text = "22";
                txtGrupo.Text = "E3B";
                txtCarrera.Text = "Ing. Electrica";
                txtExtraescolar.Text = "Danza";
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
