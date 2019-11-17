namespace BlackWaters_Sender
{
    partial class ConfigControl
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
            this.btnUse = new System.Windows.Forms.Button();
            this.btnTest = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPass = new FlatUI.FlatTextBox();
            this.txtUser = new FlatUI.FlatTextBox();
            this.checkAuth = new Bunifu.Framework.UI.BunifuCheckbox();
            this.checkSSL = new Bunifu.Framework.UI.BunifuCheckbox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtServer = new FlatUI.FlatTextBox();
            this.SuspendLayout();
            // 
            // btnUse
            // 
            this.btnUse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.btnUse.Location = new System.Drawing.Point(286, 323);
            this.btnUse.Name = "btnUse";
            this.btnUse.Size = new System.Drawing.Size(113, 23);
            this.btnUse.TabIndex = 17;
            this.btnUse.Text = "Use";
            this.btnUse.UseVisualStyleBackColor = true;
            this.btnUse.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnTest
            // 
            this.btnTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.btnTest.Location = new System.Drawing.Point(153, 323);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(113, 23);
            this.btnTest.TabIndex = 16;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label4.Location = new System.Drawing.Point(143, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Location = new System.Drawing.Point(172, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "User";
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.Color.Transparent;
            this.txtPass.FocusOnHover = false;
            this.txtPass.Location = new System.Drawing.Point(219, 257);
            this.txtPass.MaxLength = 32767;
            this.txtPass.Multiline = false;
            this.txtPass.Name = "txtPass";
            this.txtPass.ReadOnly = false;
            this.txtPass.Size = new System.Drawing.Size(147, 29);
            this.txtPass.TabIndex = 13;
            this.txtPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPass.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtPass.UseSystemPasswordChar = false;
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.Color.Transparent;
            this.txtUser.FocusOnHover = false;
            this.txtUser.Location = new System.Drawing.Point(219, 212);
            this.txtUser.MaxLength = 32767;
            this.txtUser.Multiline = false;
            this.txtUser.Name = "txtUser";
            this.txtUser.ReadOnly = false;
            this.txtUser.Size = new System.Drawing.Size(147, 29);
            this.txtUser.TabIndex = 12;
            this.txtUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtUser.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtUser.UseSystemPasswordChar = false;
            this.txtUser.TextChanged += new System.EventHandler(this.txtUser_TextChanged);
            // 
            // checkAuth
            // 
            this.checkAuth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.checkAuth.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.checkAuth.Checked = true;
            this.checkAuth.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.checkAuth.ForeColor = System.Drawing.Color.White;
            this.checkAuth.Location = new System.Drawing.Point(176, 133);
            this.checkAuth.Name = "checkAuth";
            this.checkAuth.Size = new System.Drawing.Size(20, 20);
            this.checkAuth.TabIndex = 10;
            // 
            // checkSSL
            // 
            this.checkSSL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.checkSSL.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.checkSSL.Checked = true;
            this.checkSSL.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.checkSSL.ForeColor = System.Drawing.Color.White;
            this.checkSSL.Location = new System.Drawing.Point(176, 102);
            this.checkSSL.Name = "checkSSL";
            this.checkSSL.Size = new System.Drawing.Size(20, 20);
            this.checkSSL.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Location = new System.Drawing.Point(268, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Use Auth";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(217, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Use Secured Connection";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label5.Location = new System.Drawing.Point(167, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "Server";
            // 
            // txtServer
            // 
            this.txtServer.BackColor = System.Drawing.Color.Transparent;
            this.txtServer.FocusOnHover = false;
            this.txtServer.Location = new System.Drawing.Point(219, 166);
            this.txtServer.MaxLength = 32767;
            this.txtServer.Multiline = false;
            this.txtServer.Name = "txtServer";
            this.txtServer.ReadOnly = false;
            this.txtServer.Size = new System.Drawing.Size(147, 29);
            this.txtServer.TabIndex = 18;
            this.txtServer.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtServer.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtServer.UseSystemPasswordChar = false;
            this.txtServer.TextChanged += new System.EventHandler(this.txtServer_TextChanged);
            // 
            // ConfigControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtServer);
            this.Controls.Add(this.btnUse);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.checkAuth);
            this.Controls.Add(this.checkSSL);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ConfigControl";
            this.Size = new System.Drawing.Size(563, 472);
            this.Load += new System.EventHandler(this.ConfigControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public FlatUI.FlatTextBox txtPass;
        public FlatUI.FlatTextBox txtUser;
        public System.Windows.Forms.Button btnTest;
        public System.Windows.Forms.Button btnUse;
        private System.Windows.Forms.Label label5;
        public FlatUI.FlatTextBox txtServer;
        public Bunifu.Framework.UI.BunifuCheckbox checkAuth;
        public Bunifu.Framework.UI.BunifuCheckbox checkSSL;
    }
}
