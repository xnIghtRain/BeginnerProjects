using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace StopUhr
{
    public partial class Form1 : Form
    {

        // Variablen

        int timeMs, timeSec, timeMin;        
        bool isActive;
              

        public Form1()
        {
            InitializeComponent();
        }

        // Bei Aufmachen des Programms
        private void Form1_Load(object sender, EventArgs e)
        {
            ResetTime();
            isActive = false;
        }

        // Funktionen

        private void ResetTime()
        {
            timeMs = 0;
            timeSec = 0;
            timeMin = 0;
        }

        private void DrawTime()
        {
            lmin.Text = String.Format("{0:00}", timeMin);
            lsec.Text = String.Format("{0:00}", timeSec);
            lmsec.Text = String.Format("{0:00}", timeMs);
        }

        // Aktionen

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isActive)
            {
                timeMs++;

                if (timeMs >= 65)
                {
                    timeSec++;
                    timeMs = 0;

                    if (timeSec >= 60)
                    {
                        timeMin++;
                        timeSec = 0;
                    } 
                }
            }
            DrawTime();
        }

        private void xstart_Click(object sender, EventArgs e)
        {
            isActive = true;
        }
        
        private void xstop_Click(object sender, EventArgs e)
        {
            isActive = false;
        }

        private void xreset_Click(object sender, EventArgs e)
        {
            isActive = false;
            ResetTime();
        }

        
    }
}
