namespace WindowsFormsApp1
{
    partial class userLoginForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(userLoginForm));
            this.userIdLabel = new System.Windows.Forms.Label();
            this.userIdTxt = new System.Windows.Forms.TextBox();
            this.loginBtn = new System.Windows.Forms.Button();
            this.userPwdLabel = new System.Windows.Forms.Label();
            this.userPwTxt = new System.Windows.Forms.TextBox();
            this.accountBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.userIdSave = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // userIdLabel
            // 
            this.userIdLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.userIdLabel.AutoSize = true;
            this.userIdLabel.BackColor = System.Drawing.SystemColors.Control;
            this.userIdLabel.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.userIdLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.userIdLabel.Location = new System.Drawing.Point(438, 334);
            this.userIdLabel.Name = "userIdLabel";
            this.userIdLabel.Size = new System.Drawing.Size(55, 30);
            this.userIdLabel.TabIndex = 0;
            this.userIdLabel.Text = "학번";
            // 
            // userIdTxt
            // 
            this.userIdTxt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.userIdTxt.BackColor = System.Drawing.SystemColors.Control;
            this.userIdTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userIdTxt.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.userIdTxt.ForeColor = System.Drawing.SystemColors.WindowText;
            this.userIdTxt.Location = new System.Drawing.Point(445, 383);
            this.userIdTxt.Name = "userIdTxt";
            this.userIdTxt.Size = new System.Drawing.Size(194, 22);
            this.userIdTxt.TabIndex = 1;
            // 
            // loginBtn
            // 
            this.loginBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.loginBtn.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.loginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginBtn.FlatAppearance.BorderSize = 0;
            this.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginBtn.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.loginBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.loginBtn.Location = new System.Drawing.Point(441, 570);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(108, 39);
            this.loginBtn.TabIndex = 3;
            this.loginBtn.Text = "로그인";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // userPwdLabel
            // 
            this.userPwdLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.userPwdLabel.AutoSize = true;
            this.userPwdLabel.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.userPwdLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.userPwdLabel.Location = new System.Drawing.Point(440, 429);
            this.userPwdLabel.Name = "userPwdLabel";
            this.userPwdLabel.Size = new System.Drawing.Size(88, 25);
            this.userPwdLabel.TabIndex = 3;
            this.userPwdLabel.Text = "비밀번호";
            // 
            // userPwTxt
            // 
            this.userPwTxt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.userPwTxt.BackColor = System.Drawing.SystemColors.Control;
            this.userPwTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userPwTxt.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.userPwTxt.Location = new System.Drawing.Point(445, 478);
            this.userPwTxt.Name = "userPwTxt";
            this.userPwTxt.PasswordChar = '*';
            this.userPwTxt.Size = new System.Drawing.Size(194, 22);
            this.userPwTxt.TabIndex = 2;
            // 
            // accountBtn
            // 
            this.accountBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.accountBtn.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.accountBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.accountBtn.FlatAppearance.BorderSize = 0;
            this.accountBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.accountBtn.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.accountBtn.Location = new System.Drawing.Point(567, 570);
            this.accountBtn.Name = "accountBtn";
            this.accountBtn.Size = new System.Drawing.Size(108, 40);
            this.accountBtn.TabIndex = 4;
            this.accountBtn.Text = "회원가입";
            this.accountBtn.UseVisualStyleBackColor = false;
            this.accountBtn.Click += new System.EventHandler(this.accountBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(144, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(785, 302);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // userIdSave
            // 
            this.userIdSave.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.userIdSave.AutoSize = true;
            this.userIdSave.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.userIdSave.Location = new System.Drawing.Point(443, 521);
            this.userIdSave.Name = "userIdSave";
            this.userIdSave.Size = new System.Drawing.Size(93, 24);
            this.userIdSave.TabIndex = 7;
            this.userIdSave.Text = "학번 저장";
            this.userIdSave.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Location = new System.Drawing.Point(445, 402);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 1);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Location = new System.Drawing.Point(445, 496);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(230, 1);
            this.panel2.TabIndex = 9;
            // 
            // userLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 686);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.userIdSave);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.accountBtn);
            this.Controls.Add(this.userPwTxt);
            this.Controls.Add(this.userPwdLabel);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.userIdTxt);
            this.Controls.Add(this.userIdLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "userLoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SpaceHub";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.userLoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userIdLabel;
        private System.Windows.Forms.TextBox userIdTxt;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Label userPwdLabel;
        private System.Windows.Forms.TextBox userPwTxt;
        private System.Windows.Forms.Button accountBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox userIdSave;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}

