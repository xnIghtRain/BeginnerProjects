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
        double  netto, teilmwst, brutto, mwst;        
        
        // Buttons
        private void button1_Click(object sender, EventArgs e)
        {
            netto = double.Parse(textBox1.Text);
            teilmwst = netto * mwst;
            brutto = netto + netto * mwst;
            textBox1.Text = netto.ToString("0.00");
            textBox2.Text = teilmwst.ToString("0.00");
            textBox3.Text = brutto.ToString("0.00");
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
            mwst = double.Parse(radioButton1.Text);
            teilmwst = mwst / 100; ; 
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            mwst = double.Parse(radioButton2.Text);
            teilmwst = mwst / 100; ;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {   
            if (textBox4.Text != null)
            {
                mwst = double.Parse(textBox4.Text);                
                //textBox2.Text = Convert.ToString(b/100);
                teilmwst = mwst / 100;
            }
        }

    }
}
