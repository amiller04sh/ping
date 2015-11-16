using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblMessage.Text = "Hello World";
        }

        private void lblMessage_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "";
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            //lblMessage.Text = txtInput.Text;
            
            if (txtInput.Text == "Halloween")
            {
                lblMessage.Text = "Do the Monster Mash";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
