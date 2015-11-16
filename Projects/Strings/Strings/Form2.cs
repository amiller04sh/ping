using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Strings
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string razor = textBox1.Text;
            int razorLocation = razor.IndexOf("razor");
            string replaceRazor = "";
            int wordCount = razor.Length;
            string subRazor = razor.Substring(5, 10);

            if (razorLocation != -1)
            {
                //replaceRazor = razor.Replace("razor", "love");
                string withoutRazor = razor.Remove(razorLocation, 5);
                string withReplacement = withoutRazor.Insert(razorLocation, "scissor");
                MessageBox.Show(withReplacement);
            }

            string trimRazor = razor.Trim();
            MessageBox.Show(trimRazor);




            MessageBox.Show(replaceRazor);
            MessageBox.Show(wordCount.ToString());
        }
    }
}
