using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginPage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = "amiller";
            string password = "southhills";

            if (txtUsername.Text == username && txtPassword.Text == password)
            {
                MessageBox.Show("Successful Login");
            }
            else
            {
                if (txtUsername.Text != username && txtPassword.Text != password)
                {
                    MessageBox.Show("Incorrect password or username");
                }
                
            }    
            
                    }
    }
}
