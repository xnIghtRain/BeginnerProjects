using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taschenrechner
{
    public partial class Taschenrechner : Form
    {
        public Taschenrechner()
        {
            InitializeComponent();
        }

        /* 
         * Variable vergeben
         * Operatoren
         * Zahl1 = Zahl bevor wir ein Operator ausgewählt haben
         */

        string Operation;
        float zahl1;

        /*
         * Zahlen eingeben
         * Wenn in Box 2 eine 0 steht und nicht leer ist 
         * dann Tastenzahl eingeben
         * wenn nicht dann die Zahl was in der Box2 steht und Tastenzahl zusammen ausgeben */

        private void xnum0_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text  + "0";
        }

        private void xnum1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0" && textBox2.Text != null)
            {
                textBox2.Text = "1";
            }
            else
            {
                textBox2.Text = textBox2.Text + "1";
            }
        }

        private void xnum2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0" && textBox2.Text != null)
            {
                textBox2.Text = "2";
            }
            else
            {
                textBox2.Text = textBox2.Text + "2";
            }
        }

        private void xnum3_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0" && textBox2.Text != null)
            {
                textBox2.Text = "3";
            }
            else
            {
                textBox2.Text = textBox2.Text + "3";
            }
        }

        private void xnum4_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0" && textBox2.Text != null)
            {
                textBox2.Text = "4";
            }
            else
            {
                textBox2.Text = textBox2.Text + "4";
            }
        }

        private void xnum5_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0" && textBox2.Text != null)
            {
                textBox2.Text = "5";
            }
            else
            {
                textBox2.Text = textBox2.Text + "5";
            }
        }

        private void xnum6_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0" && textBox2.Text != null)
            {
                textBox2.Text = "6";
            }
            else
            {
                textBox2.Text = textBox2.Text + "6";
            }
        }

        private void xnum_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0" && textBox2.Text != null)
            {
                textBox2.Text = "7";
            }
            else
            {
                textBox2.Text = textBox2.Text + "7";
            }
        }

        private void xnum8_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0" && textBox2.Text != null)
            {
                textBox2.Text = "8";
            }
            else
            {
                textBox2.Text = textBox2.Text + "8";
            }
        }

        private void xnum9_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0" && textBox2.Text != null)
            {
                textBox2.Text = "9";
            }
            else
            {
                textBox2.Text = textBox2.Text + "9";
            }
        }

        private void xkomma_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0" && textBox2.Text != null)
            {
                textBox2.Text = ",";
            }
            else
            {
                textBox2.Text = textBox2.Text + ",";
            }
        }

        /*
         * Operationen eingeben
         * String/Zahl im Box 2 wird mit float.Parse in ein Nummer/Float umgewandelt und in die Variable zahl1 gespeichert
         * Gibt in Box 1 die eingegebene Nummer mit Operator an
         * Box2 wird auf 0 resettet
         */
        private void xteilen_Click(object sender, EventArgs e)
        {
            Operation = "/";
            zahl1 = float.Parse(textBox2.Text);
            textBox1.Text = textBox2.Text+" /";
            textBox2.Text = "0";
        }

        private void xmal_Click(object sender, EventArgs e)
        {
            Operation = "*";
            zahl1 = float.Parse(textBox2.Text);
            textBox1.Text = textBox2.Text + " *";
            textBox2.Text = "0";
        }

        private void xminus_Click(object sender, EventArgs e)
        {
            Operation = "-";
            zahl1 = float.Parse(textBox2.Text);
            textBox1.Text = textBox2.Text + " /";
            textBox2.Text = "0";
        }

        private void xplus_Click(object sender, EventArgs e)
        {
            Operation = "+";
            zahl1 = float.Parse(textBox2.Text);
            textBox1.Text = textBox2.Text + " +";
            textBox2.Text = "0";
        }

        /*
         * Ergebnis
         * Variable zahl2 setzen
         * Da wir die erste Zahl in Variable zahl1 gespeichert und Box2 nach der Wahl eines Operators resettet haben
         * müssen wir nun die nun eigegeben Zahl in eine zweite Variable speichern -> zahl2
         * float erg -> ergebnis der Rechnung
         */
        private void xenter_Click(object sender, EventArgs e)
        {
            float zahl2;
            zahl2 = float.Parse(textBox2.Text);

            float erg;

            if (Operation == "/")
            {
                if (textBox2.Text == "0")
                {
                    textBox2.Text = "Division durch 0 nicht möglich";
                }
                else
                {
                    erg = zahl1 / zahl2;
                    textBox1.Text = Convert.ToString(zahl1)+ " / " + Convert.ToString(zahl2)+ " =";
                    textBox2.Text = Convert.ToString(erg);
                }
            }

            if (Operation == "*")
            {
                erg = zahl1 * zahl2;
                textBox1.Text = Convert.ToString(zahl1) + " * " + Convert.ToString(zahl2) + " =";
                textBox2.Text = Convert.ToString(erg);
            }

            if (Operation == "-")
            {
                erg = zahl1 - zahl2;
                textBox1.Text = Convert.ToString(zahl1) + " - " + Convert.ToString(zahl2) + " =";
                textBox2.Text = Convert.ToString(erg);
            }

            if (Operation == "+")
            {
                erg = zahl1 + zahl2;
                textBox1.Text = Convert.ToString(zahl1) + " + " + Convert.ToString(zahl2) + " =";
                textBox2.Text = Convert.ToString(erg);
            }
        }

        /*
         * Darstellung in Box1 und Box2 wird gelöscht
         */
        private void xdelete_Click(object sender, EventArgs e)
        {
            textBox2.Text = "0";
            textBox1.Text = "";
        }
    }
}
