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
            this.userPwTxt = new System.Windows.Forms.TextBox();
            this.userNameTxt = new System.Windows.Forms.TextBox();
            this.accountActionBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // userAccountLabel
            // 
            this.userAccountLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.userAccountLabel.AutoSize = true;
            this.userAccountLabel.Font = new System.Drawing.Font("맑은 고딕", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.userAccountLabel.Location = new System.Drawing.Point(191, 85);
            this.userAccountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userAccountLabel.Name = "userAccountLabel";
            this.userAccountLabel.Size = new System.Drawing.Size(148, 45);
            this.userAccountLabel.TabIndex = 0;
            this.userAccountLabel.Text = "회원가입";
            // 
            // userIdTxt
            // 
            this.userIdTxt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.userIdTxt.BackColor = System.Drawing.SystemColors.Control;
            this.userIdTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userIdTxt.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.userIdTxt.Location = new System.Drawing.Point(182, 234);
            this.userIdTxt.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.userIdTxt.Name = "userIdTxt";
            this.userIdTxt.Size = new System.Drawing.Size(195, 22);
            this.userIdTxt.TabIndex = 1;
            // 
            // userIdLabel
            // 
            this.userIdLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.userIdLabel.AutoSize = true;
            this.userIdLabel.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.userIdLabel.Location = new System.Drawing.Point(178, 207);
            this.userIdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userIdLabel.Name = "userIdLabel";
            this.userIdLabel.Size = new System.Drawing.Size(42, 21);
            this.userIdLabel.TabIndex = 2;
            this.userIdLabel.Text = "학번";
            // 
            // userNameLabel
            // 
            this.userNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.userNameLabel.Location = new System.Drawing.Point(178, 366);
            this.userNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(42, 21);
            this.userNameLabel.TabIndex = 3;
            this.userNameLabel.Text = "이름";
            // 
            // userPwdLabel
            // 
            this.userPwdLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.userPwdLabel.AutoSize = true;
            this.userPwdLabel.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.userPwdLabel.Location = new System.Drawing.Point(178, 282);
            this.userPwdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userPwdLabel.Name = "userPwdLabel";
            this.userPwdLabel.Size = new System.Drawing.Size(74, 21);
            this.userPwdLabel.TabIndex = 4;
            this.userPwdLabel.Text = "비밀번호";
            // 
            // userPwTxt
            // 
            this.userPwTxt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.userPwTxt.BackColor = System.Drawing.SystemColors.Control;
            this.userPwTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userPwTxt.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.userPwTxt.Location = new System.Drawing.Point(182, 318);
            this.userPwTxt.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.userPwTxt.Name = "userPwTxt";
            this.userPwTxt.PasswordChar = '*';
            this.userPwTxt.Size = new System.Drawing.Size(195, 22);
            this.userPwTxt.TabIndex = 5;
            // 
            // userNameTxt
            // 
            this.userNameTxt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.userNameTxt.BackColor = System.Drawing.SystemColors.Control;
            this.userNameTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userNameTxt.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.userNameTxt.Location = new System.Drawing.Point(182, 393);
            this.userNameTxt.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.userNameTxt.Name = "userNameTxt";
            this.userNameTxt.Size = new System.Drawing.Size(195, 22);
            this.userNameTxt.TabIndex = 6;
            // 
            // accountActionBtn
            // 
            this.accountActionBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.accountActionBtn.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.accountActionBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.accountActionBtn.FlatAppearance.BorderSize = 0;
            this.accountActionBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.accountActionBtn.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.accountActionBtn.Location = new System.Drawing.Point(199, 482);
            this.accountActionBtn.Name = "accountActionBtn";
            this.accountActionBtn.Size = new System.Drawing.Size(167, 53);
            this.accountActionBtn.TabIndex = 7;
            this.accountActionBtn.Text = "회원가입";
            this.accountActionBtn.UseVisualStyleBackColor = false;
            this.accountActionBtn.Click += new System.EventHandler(this.accountActionBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Location = new System.Drawing.Point(182, 262);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(197, 1);
            this.panel1.TabIndex = 9;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel3.Location = new System.Drawing.Point(182, 346);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(197, 1);
            this.panel3.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Location = new System.Drawing.Point(182, 421);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(197, 1);
            this.panel2.TabIndex = 10;
            // 
            // userAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 640);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.accountActionBtn);
            this.Controls.Add(this.userNameTxt);
            this.Controls.Add(this.userPwTxt);
            this.Controls.Add(this.userPwdLabel);
            this.Controls.Add(this.userNameLabel);
            this.Controls.Add(this.userIdLabel);
            this.Controls.Add(this.userIdTxt);
            this.Controls.Add(this.userAccountLabel);
            this.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "userAccountForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SpaceHub";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userAccountLabel;
        private System.Windows.Forms.TextBox userIdTxt;
        private System.Windows.Forms.Label userIdLabel;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Label userPwdLabel;
        private System.Windows.Forms.TextBox userPwTxt;
        private System.Windows.Forms.TextBox userNameTxt;
        private System.Windows.Forms.Button accountActionBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
    }
}