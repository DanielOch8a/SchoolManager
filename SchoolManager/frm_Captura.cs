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
    public partial class frm_Captura : Form
    {
        public frm_Captura()
        {
            InitializeComponent();
        }


        int edad;

        private void bnt_Resultado_Click(object sender, EventArgs e)
        {
            edad = uc_RadioBtns1.radBtnValue + uc_RadioBtns2.radBtnValue
                + uc_RadioBtns3.radBtnValue + uc_RadioBtns4.radBtnValue
                + uc_RadioBtns5.radBtnValue + uc_RadioBtns6.radBtnValue
                + uc_RadioBtns7.radBtnValue + uc_RadioBtns8.radBtnValue
                + uc_RadioBtns9.radBtnValue + uc_RadioBtns10.radBtnValue;

            txt_Edad.Text = edad.ToString();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
