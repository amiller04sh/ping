using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Options1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listBox1.Items.Add("Matthew");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_MouseClick(object sender, MouseEventArgs e)
        {
            comboBox1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string[] names = name.Split(' ');
            string age = comboBox1.Text;
            string date = dateTimePicker1.Text;
            int numberOfListItems = listBox1.SelectedItems.Count;
            string[] neighbors = new string[numberOfListItems];
            for (int i = 0; i < numberOfListItems; i++)
            {
                neighbors[i] = listBox1.SelectedItems[i].ToString();
            }

            string gender = "Pat";
            if (optFemale.Checked == true)
            {
                gender = "Female";
            }
            else if (optMale.Checked == true)
            {
                gender = "Male";
            }

            string candy = "";
            if (checkBox1.Checked == true)
                candy += "Chocolate\n";
            if (checkBox2.Checked == true)
                candy += "Skittles\n";
            if (checkBox3.Checked == true)
                candy += "Cotton Candy\n";

            MessageBox.Show("Your first name is " + names[0] + "\n" +
                "Your last name is " + names[1] + "\n" +
                "Your age is " + age + "\n" + "Your next Bday is " + date + "\n"
                + "Your neighbor(s) is/are " + "\n" + string.Join("\n", neighbors) + "\n" + "Your gender is " + "\n" + gender + "\n" + 
                "Your desired candy is " + "\n" + candy + "\n"
                );

        }
    }
}
