using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackWaters_Sender
{
    public partial class Form1 : Form
    {
        private int panelWidth;
        private bool hide;
        public Form1()
        {
            InitializeComponent();
            home1.BringToFront();
            panelWidth = slidingPanel.Width;
            hide = false;
        }

        private void btnPanel_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (hide)
            {
                slidingPanel.Width = slidingPanel.Width + 10;
                if (slidingPanel.Width >= panelWidth )
                {
                    timer1.Stop();
                    hide = false;
                    this.Refresh();
                }
            }
            else
            {
                slidingPanel.Width = slidingPanel.Width - 10;
                if (slidingPanel.Width <= 0)
                {
                    timer1.Stop();
                    hide = true;
                    this.Refresh();
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            configControl1.BringToFront();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            home1.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            email_List1.BringToFront();
        }
    }
}
