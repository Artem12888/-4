using System;
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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string n = textBox1.Text;
            char d = textBox2.Text[0];
            int c = 0;

            foreach (char h in n)
            {
                if (h == d)
                    c++;
            }
            textBox3.Text = textBox3.Text + c;
        }





    }
    
}
