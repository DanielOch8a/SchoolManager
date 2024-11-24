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
    public partial class frm_Consultas : Form
    {
        public frm_Consultas()
        {
            InitializeComponent();
        }

       

        private void cbxMateria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxMateria.Text == "None")
            {

                lbxGrupo.Items.Clear();
            }

            if (cbxMateria.Text == "Álgebra Lineal")
            {

                lbxGrupo.Items.Clear();
                lbxGrupo.Items.Add("S3B");
                lbxGrupo.Items.Add("S3C");
                lbxGrupo.Items.Add("S3D");
            }

            if (cbxMateria.Text == "Estructura de Datos")
            {
                lbxGrupo.Items.Clear();
                lbxGrupo.Items.Add("S3A");
                lbxGrupo.Items.Add("S3B");
                lbxGrupo.Items.Add("S3C");

            }

            if (cbxMateria.Text == "Tópicos Avanzados de Programación")
            {
                lbxGrupo.Items.Clear();
                lbxGrupo.Items.Add("S3A");
                lbxGrupo.Items.Add("S3C");
                lbxGrupo.Items.Add("S3D");
            }
        }

        private void lbxGrupo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbxGrupo.Text == "S3A")
            {
                lbxAlumnos.Items.Clear();
                lbxAlumnos.Items.Add("Daniel Ochoa");
                lbxAlumnos.Items.Add("Arath Camacho");
                lbxAlumnos.Items.Add("Noé Jiménez");

            }
            if (lbxGrupo.Text == "S3B")
            {
                lbxAlumnos.Items.Clear();
                lbxAlumnos.Items.Add("José Soto");
                lbxAlumnos.Items.Add("Daniel Torres");
                lbxAlumnos.Items.Add("Axel Monjaraz");

            }
            if (lbxGrupo.Text == "S3C")
            {
                lbxAlumnos.Items.Clear();
                lbxAlumnos.Items.Add("Luis Talla");
                lbxAlumnos.Items.Add("Omar Manzanares");
                lbxAlumnos.Items.Add("Ricardo Martinez");

            }
            if (lbxGrupo.Text == "S3D")
            {
                lbxAlumnos.Items.Clear();
                lbxAlumnos.Items.Add("Miguel Fajardo");
                lbxAlumnos.Items.Add("Bruce Wayne");
                lbxAlumnos.Items.Add("Ryan Reynolds");

            }
        }

    

        private void lbxAlumnos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {

            StringBuilder alumnos = new StringBuilder();

            if (lbxAlumnos.SelectedItem != null)
            {
                foreach (object item in lbxAlumnos.SelectedItems)
                {
                    alumnos.AppendLine(item.ToString());
                }

                MessageBox.Show("Has seleccionado estos alumnos: \n" + alumnos.ToString(), "Alumnos",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

                cbxMateria.Text = "None";
                lbxGrupo.Items.Clear();
                lbxAlumnos.Items.Clear();
            }else
            {
                MessageBox.Show("No has seleccionado alumnos \n", "Alerta",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            cbxMateria.Text = "None";
            lbxGrupo.Items.Clear();
            lbxAlumnos.Items.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }
    }

}
