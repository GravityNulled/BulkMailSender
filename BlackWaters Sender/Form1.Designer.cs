namespace BlackWaters_Sender
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMini = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.btnSetting = new System.Windows.Forms.Button();
            this.btnPanel = new System.Windows.Forms.Button();
            this.slidingPanel = new System.Windows.Forms.Panel();
            this.btnMail = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnSocials = new System.Windows.Forms.Button();
            this.btnConfig = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panelTransition = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.aboutForm1 = new BlackWaters_Sender.AboutForm();
            this.mailing1 = new BlackWaters_Sender.Mailing();
            this.firstPage1 = new BlackWaters_Sender.firstPage();
            this.configControl1 = new BlackWaters_Sender.ConfigControl();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.slidingPanel.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnMini);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.label1);
            this.panelTransition.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(750, 32);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnMini
            // 
            this.panelTransition.SetDecoration(this.btnMini, BunifuAnimatorNS.DecorationType.None);
            this.btnMini.FlatAppearance.BorderSize = 0;
            this.btnMini.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMini.Image = ((System.Drawing.Image)(resources.GetObject("btnMini.Image")));
            this.btnMini.Location = new System.Drawing.Point(687, 3);
            this.btnMini.Name = "btnMini";
            this.btnMini.Size = new System.Drawing.Size(25, 25);
            this.btnMini.TabIndex = 3;
            this.btnMini.UseVisualStyleBackColor = true;
            this.btnMini.Click += new System.EventHandler(this.btnMini_Click);
            // 
            // btnClose
            // 
            this.panelTransition.SetDecoration(this.btnClose, BunifuAnimatorNS.DecorationType.None);
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(718, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(25, 25);
            this.btnClose.TabIndex = 2;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.panelTransition.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(291, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "BlackMailer";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.btnSetting);
            this.panel2.Controls.Add(this.btnPanel);
            this.panelTransition.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(33, 472);
            this.panel2.TabIndex = 1;
            // 
            // button2
            // 
            this.panelTransition.SetDecoration(this.button2, BunifuAnimatorNS.DecorationType.None);
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(3, 29);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(25, 25);
            this.button2.TabIndex = 2;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSetting
            // 
            this.panelTransition.SetDecoration(this.btnSetting, BunifuAnimatorNS.DecorationType.None);
            this.btnSetting.FlatAppearance.BorderSize = 0;
            this.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetting.Image = ((System.Drawing.Image)(resources.GetObject("btnSetting.Image")));
            this.btnSetting.Location = new System.Drawing.Point(3, 441);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(25, 25);
            this.btnSetting.TabIndex = 1;
            this.btnSetting.UseVisualStyleBackColor = true;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // btnPanel
            // 
            this.panelTransition.SetDecoration(this.btnPanel, BunifuAnimatorNS.DecorationType.None);
            this.btnPanel.FlatAppearance.BorderSize = 0;
            this.btnPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPanel.Image = ((System.Drawing.Image)(resources.GetObject("btnPanel.Image")));
            this.btnPanel.Location = new System.Drawing.Point(3, 73);
            this.btnPanel.Name = "btnPanel";
            this.btnPanel.Size = new System.Drawing.Size(25, 25);
            this.btnPanel.TabIndex = 0;
            this.btnPanel.UseVisualStyleBackColor = true;
            this.btnPanel.Click += new System.EventHandler(this.btnPanel_Click);
            // 
            // slidingPanel
            // 
            this.slidingPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.slidingPanel.Controls.Add(this.btnMail);
            this.slidingPanel.Controls.Add(this.btnHome);
            this.slidingPanel.Controls.Add(this.btnSocials);
            this.slidingPanel.Controls.Add(this.btnConfig);
            this.panelTransition.SetDecoration(this.slidingPanel, BunifuAnimatorNS.DecorationType.None);
            this.slidingPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.slidingPanel.Location = new System.Drawing.Point(33, 32);
            this.slidingPanel.Name = "slidingPanel";
            this.slidingPanel.Size = new System.Drawing.Size(154, 472);
            this.slidingPanel.TabIndex = 2;
            this.slidingPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.slidingPanel_Paint);
            // 
            // btnMail
            // 
            this.panelTransition.SetDecoration(this.btnMail, BunifuAnimatorNS.DecorationType.None);
            this.btnMail.FlatAppearance.BorderSize = 0;
            this.btnMail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMail.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.btnMail.Image = ((System.Drawing.Image)(resources.GetObject("btnMail.Image")));
            this.btnMail.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMail.Location = new System.Drawing.Point(0, 166);
            this.btnMail.Name = "btnMail";
            this.btnMail.Size = new System.Drawing.Size(152, 25);
            this.btnMail.TabIndex = 5;
            this.btnMail.Text = "Email";
            this.btnMail.UseVisualStyleBackColor = true;
            this.btnMail.Click += new System.EventHandler(this.btnMail_Click);
            // 
            // btnHome
            // 
            this.panelTransition.SetDecoration(this.btnHome, BunifuAnimatorNS.DecorationType.None);
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(3, 73);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(152, 25);
            this.btnHome.TabIndex = 3;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnSocials
            // 
            this.panelTransition.SetDecoration(this.btnSocials, BunifuAnimatorNS.DecorationType.None);
            this.btnSocials.FlatAppearance.BorderSize = 0;
            this.btnSocials.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSocials.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSocials.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.btnSocials.Image = ((System.Drawing.Image)(resources.GetObject("btnSocials.Image")));
            this.btnSocials.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSocials.Location = new System.Drawing.Point(0, 211);
            this.btnSocials.Name = "btnSocials";
            this.btnSocials.Size = new System.Drawing.Size(152, 25);
            this.btnSocials.TabIndex = 2;
            this.btnSocials.Text = "   About Me";
            this.btnSocials.UseVisualStyleBackColor = true;
            this.btnSocials.Click += new System.EventHandler(this.btnSocials_Click);
            // 
            // btnConfig
            // 
            this.panelTransition.SetDecoration(this.btnConfig, BunifuAnimatorNS.DecorationType.None);
            this.btnConfig.FlatAppearance.BorderSize = 0;
            this.btnConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfig.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfig.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.btnConfig.Image = ((System.Drawing.Image)(resources.GetObject("btnConfig.Image")));
            this.btnConfig.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfig.Location = new System.Drawing.Point(-1, 115);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(152, 25);
            this.btnConfig.TabIndex = 2;
            this.btnConfig.Text = "Config";
            this.btnConfig.UseVisualStyleBackColor = true;
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.aboutForm1);
            this.panel4.Controls.Add(this.mailing1);
            this.panel4.Controls.Add(this.firstPage1);
            this.panel4.Controls.Add(this.configControl1);
            this.panelTransition.SetDecoration(this.panel4, BunifuAnimatorNS.DecorationType.None);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(187, 32);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(563, 472);
            this.panel4.TabIndex = 3;
            // 
            // timer1
            // 
            this.timer1.Interval = 30;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.label1;
            this.bunifuDragControl2.Vertical = true;
            // 
            // panelTransition
            // 
            this.panelTransition.AnimationType = BunifuAnimatorNS.AnimationType.Leaf;
            this.panelTransition.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 1F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.panelTransition.DefaultAnimation = animation1;
            // 
            // aboutForm1
            // 
            this.aboutForm1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.panelTransition.SetDecoration(this.aboutForm1, BunifuAnimatorNS.DecorationType.None);
            this.aboutForm1.Location = new System.Drawing.Point(0, 3);
            this.aboutForm1.Name = "aboutForm1";
            this.aboutForm1.Size = new System.Drawing.Size(563, 472);
            this.aboutForm1.TabIndex = 7;
            this.aboutForm1.Load += new System.EventHandler(this.aboutForm1_Load);
            // 
            // mailing1
            // 
            this.mailing1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.panelTransition.SetDecoration(this.mailing1, BunifuAnimatorNS.DecorationType.None);
            this.mailing1.Location = new System.Drawing.Point(-3, 0);
            this.mailing1.Name = "mailing1";
            this.mailing1.passTextBox = "";
            this.mailing1.Size = new System.Drawing.Size(563, 448);
            this.mailing1.smtpServerBox = "";
            this.mailing1.TabIndex = 6;
            this.mailing1.userTextBox = "";
            // 
            // firstPage1
            // 
            this.firstPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.panelTransition.SetDecoration(this.firstPage1, BunifuAnimatorNS.DecorationType.None);
            this.firstPage1.Location = new System.Drawing.Point(0, 0);
            this.firstPage1.Name = "firstPage1";
            this.firstPage1.Size = new System.Drawing.Size(563, 472);
            this.firstPage1.TabIndex = 5;
            // 
            // configControl1
            // 
            this.configControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.panelTransition.SetDecoration(this.configControl1, BunifuAnimatorNS.DecorationType.None);
            this.configControl1.Location = new System.Drawing.Point(0, 1);
            this.configControl1.Name = "configControl1";
            this.configControl1.Size = new System.Drawing.Size(563, 472);
            this.configControl1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(750, 504);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.slidingPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.panelTransition.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.slidingPanel.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.Button btnPanel;
        private System.Windows.Forms.Panel slidingPanel;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMini;
        private System.Windows.Forms.Button btnConfig;
        private System.Windows.Forms.Button btnSocials;
        private System.Windows.Forms.Timer timer1;
        private ConfigControl configControl1;
        private System.Windows.Forms.Button btnHome;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private BunifuAnimatorNS.BunifuTransition panelTransition;
        private System.Windows.Forms.Button button2;
        
        private firstPage firstPage1;
        private Mailing mailing1;
        private AboutForm aboutForm1;
        private System.Windows.Forms.Button btnMail;
    }
}

