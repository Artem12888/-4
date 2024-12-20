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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            int sum = 1;
            for (int i = a; i <= b; i++)
            {
                Console.WriteLine(i + "");
                if (i% 3==0)
                {
                    sum *= i;
                    textBox3.Text = i.ToString();

                }
                if (i%3!=0) 
                {
                    sum *= i;
                    textBox3.Text = "ошибка число не делиться на 3 целиком";

                }

            }
            
            
            
            
                

            
            
        }
    }
}
