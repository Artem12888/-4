using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp26
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          int a= Convert.ToInt32(textBox1.Text);

            int n = 0;
            for  (int i = 2; i <= a-1; i++) 
            {
                if (a%i == 0)
                {
                   n=n+1;

                }


            }
            if (n == 0)
            {
                textBox2.Text = "число простое";

            }
            else
            {
                textBox2.Text = "число состовное";


            }
        }
    }
}
