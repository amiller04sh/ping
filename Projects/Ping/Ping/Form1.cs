﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ping
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ping = "";
            ping = textBox1.Text;
            ping = "/K cd c:/ && ping " + ping;

            System.Diagnostics.Process.Start("cmd.exe", ping);
        }
    }
}
