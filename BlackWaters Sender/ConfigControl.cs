using System;
using System.Windows.Forms;
using Limilabs.Client.SMTP;

namespace BlackWaters_Sender
{
    public partial class ConfigControl : UserControl
    {
        public ConfigControl()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        public void testServer()
        {
            var TestSmtp = new Smtp();
            if (checkSSL.Checked)
                TestSmtp.ConnectSSL(txtServer.Text);
            else
                TestSmtp.Connect(txtServer.Text);
            if (txtUser.Text != string.Empty && txtPass.Text != string.Empty)
                TestSmtp.UseBestLogin(txtUser.Text, txtPass.Text);
            if (TestSmtp.Connected)
                MessageBox.Show("Working Smtp Server", "Connected", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            testServer();
        }

        private void ConfigControl_Load(object sender, EventArgs e)
        {
            //checkAuth.Checked = false;
            //checkSSL.Checked = false;
        }

        private void txtServer_TextChanged(object sender, EventArgs e)
        {
        }
    }
}