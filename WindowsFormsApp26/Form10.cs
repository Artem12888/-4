﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp26
{
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string n = textBox1.Text;
            int a = 0;
            foreach (char d in n)
            {
                int b = int.Parse(d.ToString());
                if (b > a)
                {
                    a = b;
                }
            }
            textBox2.Text = a.ToString();

        }
    }
}
