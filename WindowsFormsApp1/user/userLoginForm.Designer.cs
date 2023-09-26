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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // userIdLabel
            // 
            this.userIdLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.userIdLabel.AutoSize = true;
            this.userIdLabel.Font = new System.Drawing.Font("맑은 고딕", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.userIdLabel.Location = new System.Drawing.Point(586, 544);
            this.userIdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userIdLabel.Name = "userIdLabel";
            this.userIdLabel.Size = new System.Drawing.Size(106, 55);
            this.userIdLabel.TabIndex = 0;
            this.userIdLabel.Text = "학번";
            // 
            // userIdTxt
            // 
            this.userIdTxt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.userIdTxt.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.userIdTxt.ForeColor = System.Drawing.SystemColors.WindowText;
            this.userIdTxt.Location = new System.Drawing.Point(753, 556);
            this.userIdTxt.Margin = new System.Windows.Forms.Padding(4);
            this.userIdTxt.Name = "userIdTxt";
            this.userIdTxt.Size = new System.Drawing.Size(225, 39);
            this.userIdTxt.TabIndex = 1;
            // 
            // loginBtn
            // 
            this.loginBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.loginBtn.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.loginBtn.Location = new System.Drawing.Point(1014, 550);
            this.loginBtn.Margin = new System.Windows.Forms.Padding(4);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(151, 136);
            this.loginBtn.TabIndex = 2;
            this.loginBtn.Text = "로그인";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // userPwdLabel
            // 
            this.userPwdLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.userPwdLabel.AutoSize = true;
            this.userPwdLabel.Font = new System.Drawing.Font("맑은 고딕", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.userPwdLabel.Location = new System.Drawing.Point(551, 627);
            this.userPwdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userPwdLabel.Name = "userPwdLabel";
            this.userPwdLabel.Size = new System.Drawing.Size(188, 55);
            this.userPwdLabel.TabIndex = 3;
            this.userPwdLabel.Text = "비밀번호";
            // 
            // userPwTxt
            // 
            this.userPwTxt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.userPwTxt.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.userPwTxt.Location = new System.Drawing.Point(753, 639);
            this.userPwTxt.Margin = new System.Windows.Forms.Padding(4);
            this.userPwTxt.Name = "userPwTxt";
            this.userPwTxt.PasswordChar = '*';
            this.userPwTxt.Size = new System.Drawing.Size(225, 39);
            this.userPwTxt.TabIndex = 4;
            // 
            // accountBtn
            // 
            this.accountBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.accountBtn.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.accountBtn.Location = new System.Drawing.Point(790, 752);
            this.accountBtn.Margin = new System.Windows.Forms.Padding(4);
            this.accountBtn.Name = "accountBtn";
            this.accountBtn.Size = new System.Drawing.Size(151, 51);
            this.accountBtn.TabIndex = 5;
            this.accountBtn.Text = "회원가입";
            this.accountBtn.UseVisualStyleBackColor = true;
            this.accountBtn.Click += new System.EventHandler(this.accountBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(283, 71);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1121, 453);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // userLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1644, 1029);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.accountBtn);
            this.Controls.Add(this.userPwTxt);
            this.Controls.Add(this.userPwdLabel);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.userIdTxt);
            this.Controls.Add(this.userIdLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "userLoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
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
    }
}

