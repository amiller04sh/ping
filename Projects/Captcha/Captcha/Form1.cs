using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Captcha
{
    public partial class Form1 : Form
    {
        string code = "";
        Random rand;
    
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rand = new Random();

            for (int i = 0; i < 8; i++)
            {
                int counter = rand.Next(0, 3);
                switch (counter)
                {
                    case 0:
                        code += Convert.ToChar(rand.Next(65, 91));
                        break;
                    case 1:
                        code += Convert.ToChar(rand.Next(97, 123));
                        break;
                    case 2:
                        code += Convert.ToChar(rand.Next(48, 58));
                        break;
                    default:
                        code += "$";
                        break;
                }
                
            }
            lblCode.Text = code;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtBox1.Text == code)
            {
                MessageBox.Show("You got it correct!");
            }
            else
            {
                MessageBox.Show("Inccorect. Try Again.");
            }

        }
    }
}
