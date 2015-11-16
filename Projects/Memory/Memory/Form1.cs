using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memory
{
    public partial class Form1 : Form
    {

        Random rnd = new Random();
        int randompic1;
        int randompic2;
        int turn = 0;
        string card;
        string selectedcard;

        public Form1()
        {
            InitializeComponent();
            randompic1 = rnd.Next(1, 5);
            randompic2 = rnd.Next(1, 5);
            while (randompic2 == randompic1)
            {
                randompic2 = rnd.Next(1, 5);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (randompic1 == 1 || randompic2 == 1)
            {
                button1.Image = Memory.Properties.Resources.ram_125;
                card = "ram";
            }
            else
            {
                button1.Image = Memory.Properties.Resources.harddrive_125;
                card = "harddrive";
            }
            if (turn == 0)
            {
                selectedcard = card;
                turn = 1;
            }
            else
            {
                if (turn == 1)
                {
                    if (selectedcard == card)
                    {
                        MessageBox.Show("You got a match!");
                        Application.Restart();
                    }
                    else
                    {
                        MessageBox.Show("No Match!");
                        Application.Restart();
                    }
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (randompic1 == 2 || randompic2 == 2)
            {
                button2.Image = Memory.Properties.Resources.ram_125;
                card = "ram";
            }
            else
            {
                button2.Image = Memory.Properties.Resources.harddrive_125;
                card = "harddrive";
            }
            if (turn == 0)
            {
                selectedcard = card;
                turn = 1;
            }
            else
            {
                if (turn == 1)
                {
                    if (selectedcard == card)
                    {
                        MessageBox.Show("You got a match!");
                        Application.Restart();
                    }
                    else
                    {
                        MessageBox.Show("No Match!");
                        Application.Restart();
                    }
                }
            }
        }






        private void button3_Click(object sender, EventArgs e)
        {
            if (randompic1 == 3 || randompic2 == 3)
            {
                button3.Image = Memory.Properties.Resources.ram_125;
                card = "ram";
            }
            else
            {
                button3.Image = Memory.Properties.Resources.harddrive_125;
                card = "harddrive";
            }
            if (turn == 0)
            {
                selectedcard = card;
                turn = 1;
            }
            else
            {
                if (turn == 1)
                {
                    if (selectedcard == card)
                    {
                        MessageBox.Show("You got a match!");
                        Application.Restart();
                    }
                    else
                    {
                        MessageBox.Show("No Match!");
                        Application.Restart();
                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (randompic1 == 4 || randompic2 == 4)
            {
                button4.Image = Memory.Properties.Resources.ram_125;
                card = "ram";
            }
            else
            {
                button4.Image = Memory.Properties.Resources.harddrive_125;
                card = "harddrive";
            }
            if (turn == 0)
            {
                selectedcard = card;
                turn = 1;
            }
            else
            {
                if (turn == 1)
                {
                    if (selectedcard == card)
                    {
                        MessageBox.Show("You got a match!");
                        Application.Restart();
                    }
                    else
                    {
                        MessageBox.Show("No Match!");
                        Application.Restart();
                    }
                }
            }
        }
    }
}
