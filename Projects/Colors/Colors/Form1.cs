using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Colors
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMessage_Click(object sender, EventArgs e)
        {
            string[] colors = new string[7] { "red", "orange", "yellow", "green", "blue", "indigo", "violet" };
            

            if (txtboxC.Text == [0])
            {
                MessageBox.Show("Most fire engines are red.");
            }
            if (txtboxC.Text == [1])
            {
                MessageBox.Show("Orange is a great color and even better fruit.");
            }
            if (txtboxC.Text == [2])
            {
                MessageBox.Show("Bananas are yellow!");
            }
            if (txtboxC.Text == [3])
            {
                MessageBox.Show("Greeen is my favorite color.");
            }
            if (txtboxC.Text == [4])
            {
                MessageBox.Show("Blue is often associated with sadness.");
            }
            if (txtboxC.Text == [5])
            {
                MessageBox.Show("Indigo is a silly name for a color.");
            }
            if (txtboxC.Text == [6])
            {
                MessageBox.Show("Violet is also a very common girls name.");
            }
        }
    }
}
