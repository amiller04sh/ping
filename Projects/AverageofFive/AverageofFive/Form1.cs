using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AverageofFive
{
    public partial class Form1 : Form
    {
        double[] num = new double[5];
       
       
     
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAverage_Click(object sender, EventArgs e)
        {

            num[0] = Convert.ToDouble(txtBox1.Text);
            num[1] = Convert.ToDouble(txtBox2.Text);
            num[2] = Convert.ToDouble(txtBox3.Text);
            num[3] = Convert.ToDouble(txtBox4.Text);
            num[4] = Convert.ToDouble(txtBox5.Text);


            double total = num[0] + num[1] + num[2] + num[3] + num[4];
            double average;

            average = total / num.Length;
           
            lblAverage.Text = Convert.ToString(average);
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            
        }
    }
}
