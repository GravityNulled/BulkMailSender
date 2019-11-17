using System;
using System.Windows.Forms;
using TrinitySeal;

namespace BlackWaters_Sender
{
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();

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
                Seal.Secret = "PeB32KMjgTCLg4Mn0tGdf44CttXOA2FvWz7GDx4pOMdgV";
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