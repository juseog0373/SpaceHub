namespace WindowsFormsApp1
{
    partial class selectClassForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(selectClassForm));
            this.selectClassLabel = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.selectDateTimeLabel = new System.Windows.Forms.Label();
            this.classNameLabel1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.classLabel3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.floor5 = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.classLabel4 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.classNameLabel2 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.floor4 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.floor5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // selectClassLabel
            // 
            this.selectClassLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.selectClassLabel.AutoSize = true;
            this.selectClassLabel.Font = new System.Drawing.Font("맑은 고딕", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.selectClassLabel.Location = new System.Drawing.Point(920, 54);
            this.selectClassLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.selectClassLabel.Name = "selectClassLabel";
            this.selectClassLabel.Size = new System.Drawing.Size(297, 67);
            this.selectClassLabel.TabIndex = 0;
            this.selectClassLabel.Text = "강의실 조회";
            this.selectClassLabel.Click += new System.EventHandler(this.selectClassLabel_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dateTimePicker1.Location = new System.Drawing.Point(935, 157);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(275, 28);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // selectDateTimeLabel
            // 
            this.selectDateTimeLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.selectDateTimeLabel.AutoSize = true;
            this.selectDateTimeLabel.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.selectDateTimeLabel.Location = new System.Drawing.Point(778, 148);
            this.selectDateTimeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.selectDateTimeLabel.Name = "selectDateTimeLabel";
            this.selectDateTimeLabel.Size = new System.Drawing.Size(149, 41);
            this.selectDateTimeLabel.TabIndex = 3;
            this.selectDateTimeLabel.Text = "날짜 선택";
            // 
            // classNameLabel1
            // 
            this.classNameLabel1.AutoSize = true;
            this.classNameLabel1.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.classNameLabel1.Location = new System.Drawing.Point(339, 152);
            this.classNameLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.classNameLabel1.Name = "classNameLabel1";
            this.classNameLabel1.Size = new System.Drawing.Size(320, 41);
            this.classNameLabel1.TabIndex = 4;
            this.classNameLabel1.Text = "5층 - 프로젝트 실습실";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(707, 162);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 25);
            this.label4.TabIndex = 5;
            // 
            // classLabel3
            // 
            this.classLabel3.AutoSize = true;
            this.classLabel3.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.classLabel3.Location = new System.Drawing.Point(339, 646);
            this.classLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.classLabel3.Name = "classLabel3";
            this.classLabel3.Size = new System.Drawing.Size(369, 41);
            this.classLabel3.TabIndex = 19;
            this.classLabel3.Text = "5층 - 디지털미디어실습실";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApp1.Properties.Resources.b_lecture1;
            this.pictureBox2.Location = new System.Drawing.Point(40, 646);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(260, 240);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.b_lecture1;
            this.pictureBox1.Location = new System.Drawing.Point(40, 152);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(260, 240);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tabControl1.Controls.Add(this.floor5);
            this.tabControl1.Controls.Add(this.floor4);
            this.tabControl1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tabControl1.Location = new System.Drawing.Point(164, 236);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1714, 1100);
            this.tabControl1.TabIndex = 33;
            // 
            // floor5
            // 
            this.floor5.Controls.Add(this.label9);
            this.floor5.Controls.Add(this.classLabel4);
            this.floor5.Controls.Add(this.pictureBox4);
            this.floor5.Controls.Add(this.label7);
            this.floor5.Controls.Add(this.classNameLabel2);
            this.floor5.Controls.Add(this.pictureBox3);
            this.floor5.Controls.Add(this.pictureBox1);
            this.floor5.Controls.Add(this.classNameLabel1);
            this.floor5.Controls.Add(this.label4);
            this.floor5.Controls.Add(this.label5);
            this.floor5.Controls.Add(this.classLabel3);
            this.floor5.Controls.Add(this.pictureBox2);
            this.floor5.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.floor5.Location = new System.Drawing.Point(4, 34);
            this.floor5.Margin = new System.Windows.Forms.Padding(4);
            this.floor5.Name = "floor5";
            this.floor5.Padding = new System.Windows.Forms.Padding(4);
            this.floor5.Size = new System.Drawing.Size(1706, 1062);
            this.floor5.TabIndex = 0;
            this.floor5.Text = "5층";
            this.floor5.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1570, 657);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 25);
            this.label9.TabIndex = 50;
            // 
            // classLabel4
            // 
            this.classLabel4.AutoSize = true;
            this.classLabel4.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.classLabel4.Location = new System.Drawing.Point(1201, 646);
            this.classLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.classLabel4.Name = "classLabel4";
            this.classLabel4.Size = new System.Drawing.Size(307, 41);
            this.classLabel4.TabIndex = 49;
            this.classLabel4.Text = "5층 - 모바일 실습실2";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::WindowsFormsApp1.Properties.Resources.b_lecture1;
            this.pictureBox4.Location = new System.Drawing.Point(903, 646);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(260, 240);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 48;
            this.pictureBox4.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1570, 162);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 25);
            this.label7.TabIndex = 35;
            // 
            // classNameLabel2
            // 
            this.classNameLabel2.AutoSize = true;
            this.classNameLabel2.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.classNameLabel2.Location = new System.Drawing.Point(1201, 152);
            this.classNameLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.classNameLabel2.Name = "classNameLabel2";
            this.classNameLabel2.Size = new System.Drawing.Size(307, 41);
            this.classNameLabel2.TabIndex = 34;
            this.classNameLabel2.Text = "5층 - 모바일 실습실1";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::WindowsFormsApp1.Properties.Resources.b_lecture1;
            this.pictureBox3.Location = new System.Drawing.Point(903, 152);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(260, 240);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 33;
            this.pictureBox3.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(707, 657);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 25);
            this.label5.TabIndex = 20;
            // 
            // floor4
            // 
            this.floor4.Location = new System.Drawing.Point(4, 34);
            this.floor4.Margin = new System.Windows.Forms.Padding(4);
            this.floor4.Name = "floor4";
            this.floor4.Padding = new System.Windows.Forms.Padding(4);
            this.floor4.Size = new System.Drawing.Size(1706, 1062);
            this.floor4.TabIndex = 1;
            this.floor4.Text = "4층";
            this.floor4.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button2.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button2.Location = new System.Drawing.Point(1224, 148);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 43);
            this.button2.TabIndex = 35;
            this.button2.Text = "조회";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // selectClassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2034, 1368);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.selectDateTimeLabel);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.selectClassLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "selectClassForm";
            this.Text = "SpaceHub";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.selectClassForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.floor5.ResumeLayout(false);
            this.floor5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label selectClassLabel;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label selectDateTimeLabel;
        private System.Windows.Forms.Label classNameLabel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label classLabel3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage floor5;
        private System.Windows.Forms.TabPage floor4;
        private System.Windows.Forms.Label classLabel4;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label classNameLabel2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
    }
}