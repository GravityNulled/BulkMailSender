using System;
using System.Windows.Forms;
using Limilabs.Client.SMTP;

namespace BlackMailer
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

        private void TestServer()
        {
            var TestSmtp = new Smtp();
            if (checkSSL.Checked)
                TestSmtp.ConnectSSL(txtServer.Text);
            else
                TestSmtp.Connect(txtServer.Text);
            if (txtUser.Text != string.Empty && txtPass.Text != string.Empty)
            {
                try
                {
                    TestSmtp.UseBestLogin(txtUser.Text, txtPass.Text);
                    if (TestSmtp.Connected)
                        MessageBox.Show(@"Working Smtp Server", @"Connected", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                catch
                {
                    MessageBox.Show(@"Authentication Failed", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            TestServer();
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