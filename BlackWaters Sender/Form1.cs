﻿using System;
using System.Windows.Forms;

namespace BlackMailer
{
    public partial class Form1 : Form
    {
        private bool _hide;
        private readonly int _panelWidth;

        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            firstPage1.BringToFront();
            _panelWidth = slidingPanel.Width;
            _hide = false;
        }

        private void btnPanel_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (_hide)
            {
                slidingPanel.Width = slidingPanel.Width + 10;
                if (slidingPanel.Width >= _panelWidth)
                {
                    timer1.Stop();
                    _hide = false;
                    Refresh();
                }
            }
            else
            {
                slidingPanel.Width = slidingPanel.Width - 10;
                if (slidingPanel.Width <= 0)
                {
                    timer1.Stop();
                    _hide = true;
                    Refresh();
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMini_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            configControl1.BringToFront();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            firstPage1.BringToFront();
        }


        private void slidingPanel_Paint(object sender, PaintEventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (slidingPanel.Width == 50)
            {
                slidingPanel.Visible = true;
                slidingPanel.Width = 200;
                panelTransition.ShowSync(slidingPanel);
            }
            else
            {
                slidingPanel.Visible = false;
                slidingPanel.Width = 50;
                panelTransition.ShowSync(slidingPanel);
            }
        }

        private void btnSocials_Click(object sender, EventArgs e)
        {
            aboutForm1.BringToFront();
        }

        private void aboutForm1_Load(object sender, EventArgs e)
        {
        }

        private void btnMail_Click(object sender, EventArgs e)
        {
            mailing1.BringToFront();
            mailing1.SmtpServerBox = configControl1.txtServer.Text;
            mailing1.UserTextBox = configControl1.txtUser.Text;
            mailing1.PassTextBox = configControl1.txtPass.Text;
            mailing1.checkSSLMail.Checked = configControl1.checkSSL.Checked;
            mailing1.CheckAuth.Checked = configControl1.checkAuth.Checked;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"Help and Contact on About page", @"Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}