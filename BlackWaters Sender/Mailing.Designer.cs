namespace BlackMailer
{
    partial class Mailing
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mailing));
            this.SubText = new System.Windows.Forms.TextBox();
            this.tabMail = new FlatUI.FlatTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.FromText = new System.Windows.Forms.TextBox();
            this.FromNameText = new System.Windows.Forms.TextBox();
            this.tabBody = new System.Windows.Forms.TabPage();
            this.BtnEdited = new System.Windows.Forms.Button();
            this.RadioPlain = new FlatUI.FlatRadioButton();
            this.RadioHtml = new FlatUI.FlatRadioButton();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.BodyText = new System.Windows.Forms.TextBox();
            this.tabAttachment = new System.Windows.Forms.TabPage();
            this.AttachBtn = new System.Windows.Forms.Button();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.FileLocationTxt = new System.Windows.Forms.TextBox();
            this.DownloadLinkText = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.tabSendMail = new System.Windows.Forms.TabPage();
            this.bunifuCustomLabel9 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.numThreads = new FlatUI.FlatNumeric();
            this.CheckAuth = new Bunifu.Framework.UI.BunifuCheckbox();
            this.checkSSLMail = new Bunifu.Framework.UI.BunifuCheckbox();
            this.passBox = new System.Windows.Forms.TextBox();
            this.userBox = new System.Windows.Forms.TextBox();
            this.smtpServer = new System.Windows.Forms.TextBox();
            this.btnImportEmails = new System.Windows.Forms.Button();
            this.lblRem = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblSent = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblImported = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel8 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.tabMail.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.tabAttachment.SuspendLayout();
            this.tabSendMail.SuspendLayout();
            this.SuspendLayout();
            // 
            // SubText
            // 
            this.SubText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.SubText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SubText.ForeColor = System.Drawing.SystemColors.Window;
            this.SubText.Location = new System.Drawing.Point(3, 46);
            this.SubText.Multiline = true;
            this.SubText.Name = "SubText";
            this.SubText.Size = new System.Drawing.Size(178, 336);
            this.SubText.TabIndex = 24;
            this.SubText.TextChanged += new System.EventHandler(this.listBox_TextChanged);
            // 
            // tabMail
            // 
            this.tabMail.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.tabMail.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.tabMail.Controls.Add(this.tabPage1);
            this.tabMail.Controls.Add(this.tabBody);
            this.tabMail.Controls.Add(this.tabAttachment);
            this.tabMail.Controls.Add(this.tabSendMail);
            this.tabMail.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabMail.ItemSize = new System.Drawing.Size(120, 40);
            this.tabMail.Location = new System.Drawing.Point(0, 19);
            this.tabMail.Name = "tabMail";
            this.tabMail.SelectedIndex = 0;
            this.tabMail.Size = new System.Drawing.Size(563, 472);
            this.tabMail.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabMail.TabIndex = 25;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.tabPage1.Controls.Add(this.bunifuCustomLabel5);
            this.tabPage1.Controls.Add(this.bunifuCustomLabel4);
            this.tabPage1.Controls.Add(this.bunifuCustomLabel3);
            this.tabPage1.Controls.Add(this.FromText);
            this.tabPage1.Controls.Add(this.FromNameText);
            this.tabPage1.Controls.Add(this.SubText);
            this.tabPage1.Location = new System.Drawing.Point(4, 44);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(555, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Settings";
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.bunifuCustomLabel5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(250, 23);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(56, 17);
            this.bunifuCustomLabel5.TabIndex = 29;
            this.bunifuCustomLabel5.Text = "From @";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.bunifuCustomLabel4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(415, 23);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(80, 17);
            this.bunifuCustomLabel4.TabIndex = 28;
            this.bunifuCustomLabel4.Text = "From Name";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.bunifuCustomLabel3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(42, 23);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(53, 17);
            this.bunifuCustomLabel3.TabIndex = 27;
            this.bunifuCustomLabel3.Text = "Subject";
            // 
            // FromText
            // 
            this.FromText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.FromText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FromText.ForeColor = System.Drawing.SystemColors.Window;
            this.FromText.Location = new System.Drawing.Point(361, 46);
            this.FromText.Multiline = true;
            this.FromText.Name = "FromText";
            this.FromText.Size = new System.Drawing.Size(182, 336);
            this.FromText.TabIndex = 26;
            // 
            // FromNameText
            // 
            this.FromNameText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.FromNameText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FromNameText.ForeColor = System.Drawing.SystemColors.Window;
            this.FromNameText.Location = new System.Drawing.Point(187, 43);
            this.FromNameText.Multiline = true;
            this.FromNameText.Name = "FromNameText";
            this.FromNameText.Size = new System.Drawing.Size(168, 339);
            this.FromNameText.TabIndex = 25;
            this.FromNameText.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // tabBody
            // 
            this.tabBody.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.tabBody.Controls.Add(this.BtnEdited);
            this.tabBody.Controls.Add(this.RadioPlain);
            this.tabBody.Controls.Add(this.RadioHtml);
            this.tabBody.Controls.Add(this.bunifuImageButton1);
            this.tabBody.Controls.Add(this.BodyText);
            this.tabBody.Location = new System.Drawing.Point(4, 44);
            this.tabBody.Name = "tabBody";
            this.tabBody.Padding = new System.Windows.Forms.Padding(3);
            this.tabBody.Size = new System.Drawing.Size(555, 424);
            this.tabBody.TabIndex = 1;
            this.tabBody.Text = "Body";
            // 
            // BtnEdited
            // 
            this.BtnEdited.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEdited.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.BtnEdited.Location = new System.Drawing.Point(403, 3);
            this.BtnEdited.Name = "BtnEdited";
            this.BtnEdited.Size = new System.Drawing.Size(96, 35);
            this.BtnEdited.TabIndex = 33;
            this.BtnEdited.Text = "Edited";
            this.BtnEdited.UseVisualStyleBackColor = true;
            this.BtnEdited.Click += new System.EventHandler(this.BtnEdited_Click);
            // 
            // RadioPlain
            // 
            this.RadioPlain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.RadioPlain.Checked = true;
            this.RadioPlain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RadioPlain.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.RadioPlain.Location = new System.Drawing.Point(95, 13);
            this.RadioPlain.Name = "RadioPlain";
            this.RadioPlain.Options = FlatUI.FlatRadioButton._Options.Style1;
            this.RadioPlain.Size = new System.Drawing.Size(103, 22);
            this.RadioPlain.TabIndex = 32;
            this.RadioPlain.Text = "  Plain Text";
            // 
            // RadioHtml
            // 
            this.RadioHtml.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.RadioHtml.Checked = false;
            this.RadioHtml.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RadioHtml.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.RadioHtml.Location = new System.Drawing.Point(204, 13);
            this.RadioHtml.Name = "RadioHtml";
            this.RadioHtml.Options = FlatUI.FlatRadioButton._Options.Style1;
            this.RadioHtml.Size = new System.Drawing.Size(103, 22);
            this.RadioHtml.TabIndex = 31;
            this.RadioHtml.Text = "  Html";
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(71)))), ((int)(((byte)(74)))));
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.InitialImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.InitialImage")));
            this.bunifuImageButton1.Location = new System.Drawing.Point(297, 6);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(78, 33);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 30;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // BodyText
            // 
            this.BodyText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.BodyText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BodyText.ForeColor = System.Drawing.SystemColors.Window;
            this.BodyText.Location = new System.Drawing.Point(0, 41);
            this.BodyText.Multiline = true;
            this.BodyText.Name = "BodyText";
            this.BodyText.Size = new System.Drawing.Size(555, 341);
            this.BodyText.TabIndex = 26;
            this.BodyText.Text = "This is a test mail";
            this.BodyText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tabAttachment
            // 
            this.tabAttachment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.tabAttachment.Controls.Add(this.AttachBtn);
            this.tabAttachment.Controls.Add(this.bunifuCustomLabel2);
            this.tabAttachment.Controls.Add(this.bunifuCustomLabel1);
            this.tabAttachment.Controls.Add(this.FileLocationTxt);
            this.tabAttachment.Controls.Add(this.DownloadLinkText);
            this.tabAttachment.Location = new System.Drawing.Point(4, 44);
            this.tabAttachment.Name = "tabAttachment";
            this.tabAttachment.Padding = new System.Windows.Forms.Padding(3);
            this.tabAttachment.Size = new System.Drawing.Size(555, 424);
            this.tabAttachment.TabIndex = 2;
            this.tabAttachment.Text = "Attachment";
            // 
            // AttachBtn
            // 
            this.AttachBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AttachBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.AttachBtn.Location = new System.Drawing.Point(166, 88);
            this.AttachBtn.Name = "AttachBtn";
            this.AttachBtn.Size = new System.Drawing.Size(164, 35);
            this.AttachBtn.TabIndex = 6;
            this.AttachBtn.Text = "Import";
            this.AttachBtn.UseVisualStyleBackColor = true;
            this.AttachBtn.Click += new System.EventHandler(this.AttachBtn_Click);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.bunifuCustomLabel2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(227, 175);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(71, 20);
            this.bunifuCustomLabel2.TabIndex = 4;
            this.bunifuCustomLabel2.Text = "Web File";
            this.bunifuCustomLabel2.Click += new System.EventHandler(this.bunifuCustomLabel2_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.bunifuCustomLabel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(227, 44);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(76, 20);
            this.bunifuCustomLabel1.TabIndex = 3;
            this.bunifuCustomLabel1.Text = "Local File";
            // 
            // FileLocationTxt
            // 
            this.FileLocationTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.FileLocationTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FileLocationTxt.ForeColor = System.Drawing.Color.White;
            this.FileLocationTxt.Location = new System.Drawing.Point(320, 97);
            this.FileLocationTxt.Name = "FileLocationTxt";
            this.FileLocationTxt.Size = new System.Drawing.Size(143, 18);
            this.FileLocationTxt.TabIndex = 2;
            this.FileLocationTxt.Text = "File Location";
            this.FileLocationTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.FileLocationTxt.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // DownloadLinkText
            // 
            this.DownloadLinkText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DownloadLinkText.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.DownloadLinkText.ForeColor = System.Drawing.Color.White;
            this.DownloadLinkText.HintForeColor = System.Drawing.Color.Empty;
            this.DownloadLinkText.HintText = "";
            this.DownloadLinkText.isPassword = false;
            this.DownloadLinkText.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.DownloadLinkText.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.DownloadLinkText.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.DownloadLinkText.LineThickness = 3;
            this.DownloadLinkText.Location = new System.Drawing.Point(91, 212);
            this.DownloadLinkText.Margin = new System.Windows.Forms.Padding(4);
            this.DownloadLinkText.Name = "DownloadLinkText";
            this.DownloadLinkText.Size = new System.Drawing.Size(355, 37);
            this.DownloadLinkText.TabIndex = 1;
            this.DownloadLinkText.Text = "Website Url";
            this.DownloadLinkText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.DownloadLinkText.OnValueChanged += new System.EventHandler(this.bunifuMaterialTextbox1_OnValueChanged);
            // 
            // tabSendMail
            // 
            this.tabSendMail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.tabSendMail.Controls.Add(this.bunifuCustomLabel9);
            this.tabSendMail.Controls.Add(this.numThreads);
            this.tabSendMail.Controls.Add(this.CheckAuth);
            this.tabSendMail.Controls.Add(this.checkSSLMail);
            this.tabSendMail.Controls.Add(this.passBox);
            this.tabSendMail.Controls.Add(this.userBox);
            this.tabSendMail.Controls.Add(this.smtpServer);
            this.tabSendMail.Controls.Add(this.btnImportEmails);
            this.tabSendMail.Controls.Add(this.lblRem);
            this.tabSendMail.Controls.Add(this.lblSent);
            this.tabSendMail.Controls.Add(this.lblImported);
            this.tabSendMail.Controls.Add(this.bunifuCustomLabel8);
            this.tabSendMail.Controls.Add(this.bunifuCustomLabel7);
            this.tabSendMail.Controls.Add(this.bunifuCustomLabel6);
            this.tabSendMail.Controls.Add(this.btnClear);
            this.tabSendMail.Controls.Add(this.btnStart);
            this.tabSendMail.Location = new System.Drawing.Point(4, 44);
            this.tabSendMail.Name = "tabSendMail";
            this.tabSendMail.Padding = new System.Windows.Forms.Padding(3);
            this.tabSendMail.Size = new System.Drawing.Size(555, 424);
            this.tabSendMail.TabIndex = 3;
            this.tabSendMail.Text = "Send Mail";
            this.tabSendMail.Click += new System.EventHandler(this.tabSendMail_Click);
            // 
            // bunifuCustomLabel9
            // 
            this.bunifuCustomLabel9.AutoSize = true;
            this.bunifuCustomLabel9.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel9.Location = new System.Drawing.Point(325, 121);
            this.bunifuCustomLabel9.Name = "bunifuCustomLabel9";
            this.bunifuCustomLabel9.Size = new System.Drawing.Size(55, 17);
            this.bunifuCustomLabel9.TabIndex = 41;
            this.bunifuCustomLabel9.Text = "Threads";
            // 
            // numThreads
            // 
            this.numThreads.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.numThreads.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.numThreads.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.numThreads.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.numThreads.ForeColor = System.Drawing.Color.White;
            this.numThreads.Location = new System.Drawing.Point(394, 115);
            this.numThreads.Maximum = ((long)(100));
            this.numThreads.Minimum = ((long)(1));
            this.numThreads.Name = "numThreads";
            this.numThreads.Size = new System.Drawing.Size(55, 30);
            this.numThreads.TabIndex = 40;
            this.numThreads.Value = ((long)(1));
            // 
            // CheckAuth
            // 
            this.CheckAuth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.CheckAuth.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.CheckAuth.Checked = true;
            this.CheckAuth.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.CheckAuth.ForeColor = System.Drawing.Color.White;
            this.CheckAuth.Location = new System.Drawing.Point(38, 251);
            this.CheckAuth.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CheckAuth.Name = "CheckAuth";
            this.CheckAuth.Size = new System.Drawing.Size(20, 20);
            this.CheckAuth.TabIndex = 39;
            this.CheckAuth.Visible = false;
            // 
            // checkSSLMail
            // 
            this.checkSSLMail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.checkSSLMail.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.checkSSLMail.Checked = true;
            this.checkSSLMail.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.checkSSLMail.ForeColor = System.Drawing.Color.White;
            this.checkSSLMail.Location = new System.Drawing.Point(38, 208);
            this.checkSSLMail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkSSLMail.Name = "checkSSLMail";
            this.checkSSLMail.Size = new System.Drawing.Size(20, 20);
            this.checkSSLMail.TabIndex = 38;
            this.checkSSLMail.Visible = false;
            // 
            // passBox
            // 
            this.passBox.Location = new System.Drawing.Point(405, 334);
            this.passBox.Name = "passBox";
            this.passBox.Size = new System.Drawing.Size(100, 25);
            this.passBox.TabIndex = 37;
            this.passBox.Visible = false;
            // 
            // userBox
            // 
            this.userBox.Location = new System.Drawing.Point(405, 303);
            this.userBox.Name = "userBox";
            this.userBox.Size = new System.Drawing.Size(100, 25);
            this.userBox.TabIndex = 36;
            this.userBox.Visible = false;
            // 
            // smtpServer
            // 
            this.smtpServer.Location = new System.Drawing.Point(405, 272);
            this.smtpServer.Name = "smtpServer";
            this.smtpServer.Size = new System.Drawing.Size(100, 25);
            this.smtpServer.TabIndex = 35;
            this.smtpServer.Visible = false;
            // 
            // btnImportEmails
            // 
            this.btnImportEmails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImportEmails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.btnImportEmails.Location = new System.Drawing.Point(120, 60);
            this.btnImportEmails.Name = "btnImportEmails";
            this.btnImportEmails.Size = new System.Drawing.Size(164, 35);
            this.btnImportEmails.TabIndex = 34;
            this.btnImportEmails.Text = "Import";
            this.btnImportEmails.UseVisualStyleBackColor = true;
            this.btnImportEmails.Click += new System.EventHandler(this.btnImportEmails_Click);
            // 
            // lblRem
            // 
            this.lblRem.AutoSize = true;
            this.lblRem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.lblRem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblRem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRem.ForeColor = System.Drawing.Color.White;
            this.lblRem.Location = new System.Drawing.Point(311, 280);
            this.lblRem.Name = "lblRem";
            this.lblRem.Size = new System.Drawing.Size(15, 17);
            this.lblRem.TabIndex = 33;
            this.lblRem.Text = "0";
            // 
            // lblSent
            // 
            this.lblSent.AutoSize = true;
            this.lblSent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.lblSent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSent.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSent.ForeColor = System.Drawing.Color.White;
            this.lblSent.Location = new System.Drawing.Point(311, 233);
            this.lblSent.Name = "lblSent";
            this.lblSent.Size = new System.Drawing.Size(15, 17);
            this.lblSent.TabIndex = 32;
            this.lblSent.Text = "0";
            // 
            // lblImported
            // 
            this.lblImported.AutoSize = true;
            this.lblImported.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.lblImported.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblImported.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImported.ForeColor = System.Drawing.Color.White;
            this.lblImported.Location = new System.Drawing.Point(311, 188);
            this.lblImported.Name = "lblImported";
            this.lblImported.Size = new System.Drawing.Size(15, 17);
            this.lblImported.TabIndex = 31;
            this.lblImported.Text = "0";
            // 
            // bunifuCustomLabel8
            // 
            this.bunifuCustomLabel8.AutoSize = true;
            this.bunifuCustomLabel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.bunifuCustomLabel8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bunifuCustomLabel8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel8.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel8.Location = new System.Drawing.Point(214, 280);
            this.bunifuCustomLabel8.Name = "bunifuCustomLabel8";
            this.bunifuCustomLabel8.Size = new System.Drawing.Size(74, 17);
            this.bunifuCustomLabel8.TabIndex = 30;
            this.bunifuCustomLabel8.Text = "Remaining";
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.bunifuCustomLabel7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel7.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(234, 233);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(35, 17);
            this.bunifuCustomLabel7.TabIndex = 29;
            this.bunifuCustomLabel7.Text = "Sent";
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.bunifuCustomLabel6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel6.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(219, 188);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(65, 17);
            this.bunifuCustomLabel6.TabIndex = 28;
            this.bunifuCustomLabel6.Text = "Imported";
            // 
            // btnClear
            // 
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.btnClear.Location = new System.Drawing.Point(306, 60);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(164, 35);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnStart
            // 
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.btnStart.Location = new System.Drawing.Point(120, 110);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(164, 35);
            this.btnStart.TabIndex = 7;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // Mailing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.Controls.Add(this.tabMail);
            this.Name = "Mailing";
            this.Size = new System.Drawing.Size(563, 448);
            this.tabMail.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabBody.ResumeLayout(false);
            this.tabBody.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.tabAttachment.ResumeLayout(false);
            this.tabAttachment.PerformLayout();
            this.tabSendMail.ResumeLayout(false);
            this.tabSendMail.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private FlatUI.FlatTabControl tabMail;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabBody;
        private System.Windows.Forms.TextBox BodyText;
        private System.Windows.Forms.TabPage tabAttachment;
        private System.Windows.Forms.TextBox FromNameText;
        private System.Windows.Forms.TextBox FromText;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.TextBox FileLocationTxt;
        private Bunifu.Framework.UI.BunifuMaterialTextbox DownloadLinkText;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private System.Windows.Forms.Button AttachBtn;
        private FlatUI.FlatRadioButton RadioPlain;
        private FlatUI.FlatRadioButton RadioHtml;
        public System.Windows.Forms.TextBox SubText;
        private System.Windows.Forms.TabPage tabSendMail;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnStart;
        private Bunifu.Framework.UI.BunifuCustomLabel lblRem;
        private Bunifu.Framework.UI.BunifuCustomLabel lblSent;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel8;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        public Bunifu.Framework.UI.BunifuCustomLabel lblImported;
        private System.Windows.Forms.Button btnImportEmails;
        private System.Windows.Forms.TextBox smtpServer;
        private System.Windows.Forms.TextBox userBox;
        private System.Windows.Forms.TextBox passBox;
        public Bunifu.Framework.UI.BunifuCheckbox CheckAuth;
        public Bunifu.Framework.UI.BunifuCheckbox checkSSLMail;
        private System.Windows.Forms.Button BtnEdited;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel9;
        private FlatUI.FlatNumeric numThreads;
    }
}
