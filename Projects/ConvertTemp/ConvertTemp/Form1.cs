using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConvertTemp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            
            if (txtBoxF.Text.Length > 0)
            {
                double F = Convert.ToDouble(txtBoxF.Text);
                double celciusanswer = (F - 32) * 5/9;
                txtBoxC.Text = Convert.ToString(celciusanswer);
                txtBoxF.Text = "";
            }
            if (txtBoxC.Text.Length > 0)
            {
                double C = Convert.ToDouble(txtBoxC.Text);
                double fahsanswer = (C * 9) / 5 +32;
                txtBoxF.Text = Convert.ToString(fahsanswer);
                txtBoxC.Text = "";
            }


        }
    }
}
