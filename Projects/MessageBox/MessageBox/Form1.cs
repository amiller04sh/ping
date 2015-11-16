using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessageBox
{
    public partial class Form1 : Form
    {
        int randomnumber;
        Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            randomnumber = rnd.Next(1, 4);
            switch (randomnumber)
            {
                case 1:
                    lblDisplay.Text = "Nessie was spoted swimming around South Carolina in flood waters.";
                    break;

                case 2:
                    lblDisplay.Text = "The chupacabra never sleeps and will eat your goats.";
                    break;

                case 3:
                    lblDisplay.Text = "Big Foot is alive and here in PA.";
                    break;

                default:
                    lblDisplay.Text = "Sorry, The Merman came along and ate all of our quotes for the day.";
                    break;
            }

        }
    }
}
