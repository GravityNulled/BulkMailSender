using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Limilabs.Client.SMTP;
using Limilabs.Mail;
using Limilabs.Mail.Headers;

namespace BlackMailer
{
    public partial class Mailing : UserControl
    {
        private readonly List<string> _emailList = new List<string>();
        public int Errors;
        public int Hits;
        public bool Stopped;

        public Mailing()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        public string SmtpServerBox
        {
            get => smtpServer.Text;
            set => smtpServer.Text = value;
        }

        public string UserTextBox
        {
            get => userBox.Text;
            set => userBox.Text = value;
        }

        public string PassTextBox
        {
            get => passBox.Text;
            set => passBox.Text = value;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void listBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"Feature Coming Soon withh v2!");
        }

        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {
        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Parallel.ForEach(_emailList,
                new ParallelOptions {MaxDegreeOfParallelism = Convert.ToInt16(numThreads.Value)}, account =>
                {
                    var Builder = new MailBuilder();
                    Builder.From.Add(new MailBox(FromNameText.Text, FromText.Text));
                    Builder.To.Add(new MailBox(account));
                    Builder.Subject = SubText.Text;
                    if (RadioHtml.Checked)
                        Builder.Html = BodyText.Text;
                    else if (RadioPlain.Checked) Builder.Text = BodyText.Text;
                    var Mail = Builder.Create();
                    using (var Smtp = new Smtp())
                    {
                        var isChecked = checkSSLMail.Checked;
                        if (isChecked)
                            Smtp.ConnectSSL(smtpServer.Text);
                        else
                            Smtp.Connect(smtpServer.Text);

                        Smtp.UseBestLogin(userBox.Text, passBox.Text);
                        var Resut = Smtp.SendMessage(Mail);
                        if (Resut.Status == SendMessageStatus.Success)
                            MessageBox.Show(@"Ok");
                        else
                            MessageBox.Show(Resut.Status.ToString());
                    }
                });
        }

        private void btnImportEmails_Click(object sender, EventArgs e)
        {
            using (var ofd = new OpenFileDialog {FileName = "", Filter = @"Text Files | *.txt", Multiselect = false})
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    foreach (var combolist in File.ReadAllLines(ofd.FileName)) _emailList.Add(combolist);

                    lblImported.Text = Convert.ToString(_emailList.Count);
                }
            }
        }

        private void tabSendMail_Click(object sender, EventArgs e)
        {
        }

        private void BtnEdited_Click(object sender, EventArgs e)
        {
            var dt = DateTime.Now;
            var UpperChar = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var LowerChar = "abcdefghijklmnopqrstuvwxyz0123456789";
            var LowerApha = "abcdefghijklmnopqrstuvwxyz";
            var UpperApha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            var UpperCharString = new char[10];
            var UpperAlphaCharString = new char[10];
            var LowerAlphaCharString = new char[10];
            var LowerCharString = new char[10];
            var rnd = new Random();
            var random10 = rnd.Next(0, 1000000000);
            for (var i = 0; i < UpperCharString.Length; i++) UpperCharString[i] = UpperChar[rnd.Next(UpperChar.Length)];
            for (var i = 0; i < LowerCharString.Length; i++) LowerCharString[i] = LowerChar[rnd.Next(LowerChar.Length)];
            for (var i = 0; i < LowerAlphaCharString.Length; i++)
                LowerAlphaCharString[i] = LowerApha[rnd.Next(LowerApha.Length)];
            for (var i = 0; i < UpperAlphaCharString.Length; i++)
                UpperAlphaCharString[i] = UpperApha[rnd.Next(UpperApha.Length)];
            var UpperFinalChars = new string(UpperCharString);
            var LowerFinalChars = new string(LowerCharString);
            var LowerFinalAlpha = new string(LowerAlphaCharString);
            var UpperFinalAlpha = new string(UpperAlphaCharString);
            var data = BodyText.Text;
            if (data.Contains("<<date>>") || data.Contains("<<rand10>>") || data.Contains("<<randUpperNumL10>>") ||
                data.Contains("<<randLowerNumL10>>") || data.Contains("<<randUpperAlpha10>>") ||
                data.Contains("<<randLowerAlpha10>>"))
            {
                var sb = new StringBuilder(BodyText.Text);
                sb.Replace("<<date>>", dt.ToString(CultureInfo.InvariantCulture));
                sb.Replace("<<rand10>>", random10.ToString());
                sb.Replace("<<randUpperNumL10>>", UpperFinalChars);
                sb.Replace("<<randLowerNumL10>>", LowerFinalChars);
                sb.Replace("<<randUpperAlpha10>>", UpperFinalAlpha);
                sb.Replace("<<randLowerAlpha10>>", LowerFinalAlpha);
                BodyText.Text = sb.ToString();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            _emailList.Clear();
            lblImported.Text = Convert.ToString(_emailList.Count);
        }

        private void AttachBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"Coming with Update 2.0!");
        }
    }
}