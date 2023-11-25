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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button5 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.예약미승인건조회ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.예약승인건조회ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.강의실조회ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.회원조회ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(345, 144);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(1143, 691);
            this.dataGridView1.TabIndex = 4;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1519, 682);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(281, 153);
            this.button5.TabIndex = 5;
            this.button5.Text = "수정";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Y",
            "N"});
            this.comboBox1.Location = new System.Drawing.Point(1606, 589);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(194, 20);
            this.comboBox1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 12F);
            this.label1.Location = new System.Drawing.Point(1516, 593);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "승인여부";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.예약미승인건조회ToolStripMenuItem,
            this.예약승인건조회ToolStripMenuItem,
            this.강의실조회ToolStripMenuItem,
            this.회원조회ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1863, 104);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 예약미승인건조회ToolStripMenuItem
            // 
            this.예약미승인건조회ToolStripMenuItem.AutoSize = false;
            this.예약미승인건조회ToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.예약미승인건조회ToolStripMenuItem.Name = "예약미승인건조회ToolStripMenuItem";
            this.예약미승인건조회ToolStripMenuItem.Size = new System.Drawing.Size(150, 100);
            this.예약미승인건조회ToolStripMenuItem.Text = "예약 미승인건 조회";
            this.예약미승인건조회ToolStripMenuItem.Click += new System.EventHandler(this.예약미승인건조회ToolStripMenuItem_Click);
            // 
            // 예약승인건조회ToolStripMenuItem
            // 
            this.예약승인건조회ToolStripMenuItem.AutoSize = false;
            this.예약승인건조회ToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.예약승인건조회ToolStripMenuItem.Name = "예약승인건조회ToolStripMenuItem";
            this.예약승인건조회ToolStripMenuItem.Size = new System.Drawing.Size(150, 100);
            this.예약승인건조회ToolStripMenuItem.Text = "예약 승인건 조회";
            this.예약승인건조회ToolStripMenuItem.Click += new System.EventHandler(this.예약승인건조회ToolStripMenuItem_Click);
            // 
            // 강의실조회ToolStripMenuItem
            // 
            this.강의실조회ToolStripMenuItem.AutoSize = false;
            this.강의실조회ToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.강의실조회ToolStripMenuItem.Name = "강의실조회ToolStripMenuItem";
            this.강의실조회ToolStripMenuItem.Size = new System.Drawing.Size(150, 100);
            this.강의실조회ToolStripMenuItem.Text = "강의실 조회";
            this.강의실조회ToolStripMenuItem.Click += new System.EventHandler(this.강의실조회ToolStripMenuItem_Click);
            // 
            // 회원조회ToolStripMenuItem
            // 
            this.회원조회ToolStripMenuItem.AutoSize = false;
            this.회원조회ToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.회원조회ToolStripMenuItem.Name = "회원조회ToolStripMenuItem";
            this.회원조회ToolStripMenuItem.Size = new System.Drawing.Size(150, 100);
            this.회원조회ToolStripMenuItem.Text = "회원조회";
            this.회원조회ToolStripMenuItem.Click += new System.EventHandler(this.회원조회ToolStripMenuItem_Click);
            // 
            // adminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1863, 903);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "adminForm";
            this.Text = "adminForm";
            this.Load += new System.EventHandler(this.adminForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 예약미승인건조회ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 예약승인건조회ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 강의실조회ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 회원조회ToolStripMenuItem;
    }
}