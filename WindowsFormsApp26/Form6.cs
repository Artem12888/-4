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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            int sum = 0;
            for (int i = a; i <= b; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i + "");
                    sum += i;

                }
            }
            textBox3.Text = sum.ToString();
        }
    }
}
