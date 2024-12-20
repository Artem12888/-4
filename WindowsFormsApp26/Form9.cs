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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a=Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            if (a > b)
            {
                int c = a - b;
                textBox3.Text = c.ToString();
               
            }
            if (a < b)
            {
                int d = b - a;
                textBox3.Text = d.ToString();

            }


            if (a > b)
            {
                int d = b - a;
                textBox4.Text = d.ToString();

            }




        }
    }
}
