using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Sidepanel.Height = xhome.Height;
            Sidepanel.Top = xhome.Top;
            firstCustomControl1.BringToFront();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void xhome_Click(object sender, EventArgs e)
        {
            Sidepanel.Height = xhome.Height;
            Sidepanel.Top = xhome.Top;
            firstCustomControl1.BringToFront();
        }

        private void xeatin_Click(object sender, EventArgs e)
        {
            Sidepanel.Height = xeatin.Height;
            Sidepanel.Top = xeatin.Top;
            mySecondUserControl1.BringToFront();
        }
    }
}
