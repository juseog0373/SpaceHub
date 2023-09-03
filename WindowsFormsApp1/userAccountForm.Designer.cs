namespace WindowsFormsApp1
{
    partial class userAccountForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(userAccountForm));
            this.userAccountLabel = new System.Windows.Forms.Label();
            this.userIdTxt = new System.Windows.Forms.TextBox();
            this.userIdLabel = new System.Windows.Forms.Label();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.userPwdLabel = new System.Windows.Forms.Label();
            this.userPwdTxt = new System.Windows.Forms.TextBox();
            this.userNameTxt = new System.Windows.Forms.TextBox();
            this.accountActionBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userAccountLabel
            // 
            this.userAccountLabel.AutoSize = true;
            this.userAccountLabel.Font = new System.Drawing.Font("맑은 고딕", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.userAccountLabel.Location = new System.Drawing.Point(223, 65);
            this.userAccountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userAccountLabel.Name = "userAccountLabel";
            this.userAccountLabel.Size = new System.Drawing.Size(148, 45);
            this.userAccountLabel.TabIndex = 0;
            this.userAccountLabel.Text = "회원가입";
            // 
            // userIdTxt
            // 
            this.userIdTxt.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.userIdTxt.Location = new System.Drawing.Point(292, 152);
            this.userIdTxt.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.userIdTxt.Name = "userIdTxt";
            this.userIdTxt.Size = new System.Drawing.Size(128, 29);
            this.userIdTxt.TabIndex = 1;
            // 
            // userIdLabel
            // 
            this.userIdLabel.AutoSize = true;
            this.userIdLabel.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.userIdLabel.Location = new System.Drawing.Point(158, 157);
            this.userIdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userIdLabel.Name = "userIdLabel";
            this.userIdLabel.Size = new System.Drawing.Size(42, 21);
            this.userIdLabel.TabIndex = 2;
            this.userIdLabel.Text = "학번";
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.userNameLabel.Location = new System.Drawing.Point(158, 291);
            this.userNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(42, 21);
            this.userNameLabel.TabIndex = 3;
            this.userNameLabel.Text = "이름";
            // 
            // userPwdLabel
            // 
            this.userPwdLabel.AutoSize = true;
            this.userPwdLabel.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.userPwdLabel.Location = new System.Drawing.Point(146, 220);
            this.userPwdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userPwdLabel.Name = "userPwdLabel";
            this.userPwdLabel.Size = new System.Drawing.Size(74, 21);
            this.userPwdLabel.TabIndex = 4;
            this.userPwdLabel.Text = "비밀번호";
            // 
            // userPwdTxt
            // 
            this.userPwdTxt.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.userPwdTxt.Location = new System.Drawing.Point(293, 217);
            this.userPwdTxt.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.userPwdTxt.Name = "userPwdTxt";
            this.userPwdTxt.Size = new System.Drawing.Size(128, 29);
            this.userPwdTxt.TabIndex = 5;
            // 
            // userNameTxt
            // 
            this.userNameTxt.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.userNameTxt.Location = new System.Drawing.Point(292, 288);
            this.userNameTxt.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.userNameTxt.Name = "userNameTxt";
            this.userNameTxt.Size = new System.Drawing.Size(128, 29);
            this.userNameTxt.TabIndex = 6;
            // 
            // accountActionBtn
            // 
            this.accountActionBtn.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.accountActionBtn.Location = new System.Drawing.Point(242, 370);
            this.accountActionBtn.Name = "accountActionBtn";
            this.accountActionBtn.Size = new System.Drawing.Size(84, 40);
            this.accountActionBtn.TabIndex = 7;
            this.accountActionBtn.Text = "회원가입";
            this.accountActionBtn.UseVisualStyleBackColor = true;
            this.accountActionBtn.Click += new System.EventHandler(this.accountActionBtn_Click);
            // 
            // userAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 805);
            this.Controls.Add(this.accountActionBtn);
            this.Controls.Add(this.userNameTxt);
            this.Controls.Add(this.userPwdTxt);
            this.Controls.Add(this.userPwdLabel);
            this.Controls.Add(this.userNameLabel);
            this.Controls.Add(this.userIdLabel);
            this.Controls.Add(this.userIdTxt);
            this.Controls.Add(this.userAccountLabel);
            this.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "userAccountForm";
            this.Text = "SpaceHub";
            this.Load += new System.EventHandler(this.userAccountForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userAccountLabel;
        private System.Windows.Forms.TextBox userIdTxt;
        private System.Windows.Forms.Label userIdLabel;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Label userPwdLabel;
        private System.Windows.Forms.TextBox userPwdTxt;
        private System.Windows.Forms.TextBox userNameTxt;
        private System.Windows.Forms.Button accountActionBtn;
    }
}