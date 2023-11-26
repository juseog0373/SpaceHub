namespace WindowsFormsApp1
{
    partial class adminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminForm));
            this.adminDataGrid = new System.Windows.Forms.DataGridView();
            this.yesBtn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.rsrvToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.classToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectClassToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.regClassToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateClassToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteClassToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noBtn = new System.Windows.Forms.Button();
            this.rsrvLabel = new System.Windows.Forms.Label();
            this.rsrvCodeDropdown = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.adminDataGrid)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // adminDataGrid
            // 
            this.adminDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.adminDataGrid.Location = new System.Drawing.Point(21, 144);
            this.adminDataGrid.Name = "adminDataGrid";
            this.adminDataGrid.RowTemplate.Height = 23;
            this.adminDataGrid.Size = new System.Drawing.Size(1458, 747);
            this.adminDataGrid.TabIndex = 4;
            this.adminDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.adminDataGrid_CellClick);
            // 
            // yesBtn
            // 
            this.yesBtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.yesBtn.Location = new System.Drawing.Point(1531, 562);
            this.yesBtn.Name = "yesBtn";
            this.yesBtn.Size = new System.Drawing.Size(298, 153);
            this.yesBtn.TabIndex = 5;
            this.yesBtn.Text = "예약승인";
            this.yesBtn.UseVisualStyleBackColor = false;
            this.yesBtn.Click += new System.EventHandler(this.yesBtn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rsrvToolStripMenuItem,
            this.userToolStripMenuItem,
            this.classToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1863, 104);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // rsrvToolStripMenuItem
            // 
            this.rsrvToolStripMenuItem.AutoSize = false;
            this.rsrvToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.rsrvToolStripMenuItem.Name = "rsrvToolStripMenuItem";
            this.rsrvToolStripMenuItem.Size = new System.Drawing.Size(150, 100);
            this.rsrvToolStripMenuItem.Text = "예약관리";
            this.rsrvToolStripMenuItem.Click += new System.EventHandler(this.selectRsrvToolStripMenuItem_Click);
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.AutoSize = false;
            this.userToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(150, 100);
            this.userToolStripMenuItem.Text = "회원관리";
            this.userToolStripMenuItem.Click += new System.EventHandler(this.userToolStripMenuItem_Click);
            // 
            // classToolStripMenuItem
            // 
            this.classToolStripMenuItem.AutoSize = false;
            this.classToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.classToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectClassToolStripMenuItem,
            this.regClassToolStripMenuItem,
            this.updateClassToolStripMenuItem,
            this.deleteClassToolStripMenuItem});
            this.classToolStripMenuItem.Name = "classToolStripMenuItem";
            this.classToolStripMenuItem.Size = new System.Drawing.Size(150, 100);
            this.classToolStripMenuItem.Text = "강의실 관리";
            this.classToolStripMenuItem.Click += new System.EventHandler(this.classToolStripMenuItem_Click);
            // 
            // selectClassToolStripMenuItem
            // 
            this.selectClassToolStripMenuItem.Name = "selectClassToolStripMenuItem";
            this.selectClassToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.selectClassToolStripMenuItem.Text = "강의실 조회";
            this.selectClassToolStripMenuItem.Click += new System.EventHandler(this.selectClassToolStripMenuItem_Click);
            // 
            // regClassToolStripMenuItem
            // 
            this.regClassToolStripMenuItem.Name = "regClassToolStripMenuItem";
            this.regClassToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.regClassToolStripMenuItem.Text = "강의실 추가";
            this.regClassToolStripMenuItem.Click += new System.EventHandler(this.regClassToolStripMenuItem_Click);
            // 
            // updateClassToolStripMenuItem
            // 
            this.updateClassToolStripMenuItem.Name = "updateClassToolStripMenuItem";
            this.updateClassToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.updateClassToolStripMenuItem.Text = "강의실 수정";
            this.updateClassToolStripMenuItem.Click += new System.EventHandler(this.updateClassToolStripMenuItem_Click);
            // 
            // deleteClassToolStripMenuItem
            // 
            this.deleteClassToolStripMenuItem.Name = "deleteClassToolStripMenuItem";
            this.deleteClassToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteClassToolStripMenuItem.Text = "강의실 삭제";
            this.deleteClassToolStripMenuItem.Click += new System.EventHandler(this.deleteClassToolStripMenuItem_Click);
            // 
            // noBtn
            // 
            this.noBtn.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.noBtn.Location = new System.Drawing.Point(1531, 738);
            this.noBtn.Name = "noBtn";
            this.noBtn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.noBtn.Size = new System.Drawing.Size(298, 153);
            this.noBtn.TabIndex = 9;
            this.noBtn.Text = "예약거절";
            this.noBtn.UseVisualStyleBackColor = false;
            this.noBtn.Click += new System.EventHandler(this.noBtn_Click);
            // 
            // rsrvLabel
            // 
            this.rsrvLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rsrvLabel.AutoSize = true;
            this.rsrvLabel.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rsrvLabel.Location = new System.Drawing.Point(1502, 143);
            this.rsrvLabel.Name = "rsrvLabel";
            this.rsrvLabel.Size = new System.Drawing.Size(118, 21);
            this.rsrvLabel.TabIndex = 56;
            this.rsrvLabel.Text = "예약 상태 선택";
            // 
            // rsrvCodeDropdown
            // 
            this.rsrvCodeDropdown.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rsrvCodeDropdown.FormattingEnabled = true;
            this.rsrvCodeDropdown.Items.AddRange(new object[] {
            "전체",
            "승인 대기",
            "예약 승인",
            "승인 거절"});
            this.rsrvCodeDropdown.Location = new System.Drawing.Point(1640, 144);
            this.rsrvCodeDropdown.Name = "rsrvCodeDropdown";
            this.rsrvCodeDropdown.Size = new System.Drawing.Size(156, 20);
            this.rsrvCodeDropdown.TabIndex = 55;
            this.rsrvCodeDropdown.SelectedIndexChanged += new System.EventHandler(this.rsrvCodeDropdown_SelectedIndexChanged);
            // 
            // adminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1863, 903);
            this.Controls.Add(this.rsrvLabel);
            this.Controls.Add(this.rsrvCodeDropdown);
            this.Controls.Add(this.noBtn);
            this.Controls.Add(this.yesBtn);
            this.Controls.Add(this.adminDataGrid);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "adminForm";
            this.Text = "adminForm";
            this.Load += new System.EventHandler(this.adminForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.adminDataGrid)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView adminDataGrid;
        private System.Windows.Forms.Button yesBtn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem rsrvToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem classToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.Button noBtn;
        private System.Windows.Forms.Label rsrvLabel;
        private System.Windows.Forms.ComboBox rsrvCodeDropdown;
        private System.Windows.Forms.ToolStripMenuItem regClassToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateClassToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteClassToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectClassToolStripMenuItem;
    }
}