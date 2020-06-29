using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mehrwertsteuer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Variablen setzen
        double  a, b, c, d;        
        
        // Buttons
        private void button1_Click(object sender, EventArgs e)
        {
            a = double.Parse(textBox1.Text);
            b = a * d;
            c = a + a * d;
            textBox1.Text = a.ToString("0.00");
            textBox2.Text = b.ToString("0.00");
            textBox3.Text = c.ToString("0.00");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        // Mehrwertsteuersatz

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            b = double.Parse(radioButton1.Text);
            d = b / 100; ; 
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            b = double.Parse(radioButton2.Text);
            d = b / 100; ;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {   
            if (textBox4.Text != null)
            {
                b = double.Parse(textBox4.Text);                
                //textBox2.Text = Convert.ToString(b/100);
                d = b / 100;
            }
        }

    }
}
