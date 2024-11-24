using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManager
{
    public partial class uc_RadioBtns : UserControl
    {

        public int radBtnValue = 0;

        public uc_RadioBtns()
        {
            InitializeComponent();
        }


        private void radBtn1_CheckedChanged(object sender, EventArgs e)
        {
            radBtnValue = Convert.ToInt32(radBtn1.Text);
        }

        private void radBtn2_CheckedChanged(object sender, EventArgs e)
        {
            radBtnValue = Convert.ToInt32(radBtn2.Text);

        }

        private void radBtn3_CheckedChanged(object sender, EventArgs e)
        {
            radBtnValue = Convert.ToInt32(radBtn3.Text);

        }

        private void radBtn4_CheckedChanged(object sender, EventArgs e)
        {
            radBtnValue = Convert.ToInt32(radBtn4.Text);

        }

        private void radBtn5_CheckedChanged(object sender, EventArgs e)
        {
            radBtnValue = Convert.ToInt32(radBtn5.Text);
        }

        
    }
}
