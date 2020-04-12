using System;
using System.Windows.Forms;
using TrinitySeal;

namespace BlackMailer
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            panel1.Visible = false;
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Form_Load(object sender, EventArgs e)
        {
            SealCheck.HashChecks();
            if (SealCheck.isValidDLL)
            {
                Seal.Secret = "9cXppSOhiiNuEUcFZpxvhwPTW0b25H1eDH3c4G226XHHN";
                Seal.Initialize("1.0");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SealCheck.HashChecks();
            var response = Seal.Login(txtLoginUser.Text, txtLoginPassword.Text);
            if (response)
            {
                Hide();
                new Form1().Show();
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SealCheck.HashChecks();
            var response = Seal.Register(txtRegUserName.Text, txtRegPassword.Text, txtReEmail.Text, txtRegCoupon.Text);
            if (response)
            {
            }
        }
    }
}