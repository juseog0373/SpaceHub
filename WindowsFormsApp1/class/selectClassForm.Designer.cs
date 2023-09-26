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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(selectClassForm));
            this.selectClassDataGrid = new System.Windows.Forms.DataGridView();
            this.reservationBtn = new System.Windows.Forms.Button();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.classNameDropDown = new System.Windows.Forms.ComboBox();
            this.classNameLabel = new System.Windows.Forms.Label();
            this.selectClassBtn = new System.Windows.Forms.Button();
            this.startHoursDropDown = new System.Windows.Forms.ComboBox();
            this.rsrvHoursUseLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.endHoursDropDown = new System.Windows.Forms.ComboBox();
            this.rsrvPrsnlLabel = new System.Windows.Forms.Label();
            this.rsrvGoal = new System.Windows.Forms.TextBox();
            this.rsrvGoalLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.selectClassDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // selectClassDataGrid
            // 
            this.selectClassDataGrid.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.selectClassDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.selectClassDataGrid.Anchor = System.Windows.Forms.AnchorStyles.Top;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.selectClassDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.selectClassDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.selectClassDataGrid.Location = new System.Drawing.Point(32, 52);
            this.selectClassDataGrid.Name = "selectClassDataGrid";
            this.selectClassDataGrid.RowTemplate.Height = 23;
            this.selectClassDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.selectClassDataGrid.Size = new System.Drawing.Size(825, 571);
            this.selectClassDataGrid.TabIndex = 0;
            // 
            // reservationBtn
            // 
            this.reservationBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.reservationBtn.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.reservationBtn.Location = new System.Drawing.Point(888, 484);
            this.reservationBtn.Name = "reservationBtn";
            this.reservationBtn.Size = new System.Drawing.Size(276, 139);
            this.reservationBtn.TabIndex = 2;
            this.reservationBtn.Text = "예약";
            this.reservationBtn.UseVisualStyleBackColor = true;
            this.reservationBtn.Click += new System.EventHandler(this.reservationBtn_Click);
            // 
            // datePicker
            // 
            this.datePicker.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.datePicker.Location = new System.Drawing.Point(888, 265);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(276, 21);
            this.datePicker.TabIndex = 3;
            // 
            // classNameDropDown
            // 
            this.classNameDropDown.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.classNameDropDown.FormattingEnabled = true;
            this.classNameDropDown.Items.AddRange(new object[] {
            "전산관 5층",
            "전산관 4층",
            "전산관 3층",
            "전산관 2층",
            "임곡관 2층",
            "임곡관 1층"});
            this.classNameDropDown.Location = new System.Drawing.Point(1008, 52);
            this.classNameDropDown.Name = "classNameDropDown";
            this.classNameDropDown.Size = new System.Drawing.Size(156, 20);
            this.classNameDropDown.TabIndex = 4;
            // 
            // classNameLabel
            // 
            this.classNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.classNameLabel.AutoSize = true;
            this.classNameLabel.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.classNameLabel.Location = new System.Drawing.Point(884, 51);
            this.classNameLabel.Name = "classNameLabel";
            this.classNameLabel.Size = new System.Drawing.Size(118, 21);
            this.classNameLabel.TabIndex = 5;
            this.classNameLabel.Text = "강의실 층 선택";
            // 
            // selectClassBtn
            // 
            this.selectClassBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.selectClassBtn.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.selectClassBtn.Location = new System.Drawing.Point(888, 89);
            this.selectClassBtn.Name = "selectClassBtn";
            this.selectClassBtn.Size = new System.Drawing.Size(276, 84);
            this.selectClassBtn.TabIndex = 6;
            this.selectClassBtn.Text = "조회";
            this.selectClassBtn.UseVisualStyleBackColor = true;
            this.selectClassBtn.Click += new System.EventHandler(this.selectClassBtn_Click);
            // 
            // startHoursDropDown
            // 
            this.startHoursDropDown.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.startHoursDropDown.FormattingEnabled = true;
            this.startHoursDropDown.Items.AddRange(new object[] {
            "09:00",
            "10:00",
            "11:00",
            "12:00",
            "13:00",
            "14:00",
            "15:00",
            "16:00",
            "17:00",
            "18:00",
            "19:00",
            "20:00",
            "21:00"});
            this.startHoursDropDown.Location = new System.Drawing.Point(964, 318);
            this.startHoursDropDown.Name = "startHoursDropDown";
            this.startHoursDropDown.Size = new System.Drawing.Size(81, 20);
            this.startHoursDropDown.TabIndex = 10;
            // 
            // rsrvHoursUseLabel
            // 
            this.rsrvHoursUseLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rsrvHoursUseLabel.AutoSize = true;
            this.rsrvHoursUseLabel.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rsrvHoursUseLabel.Location = new System.Drawing.Point(884, 317);
            this.rsrvHoursUseLabel.Name = "rsrvHoursUseLabel";
            this.rsrvHoursUseLabel.Size = new System.Drawing.Size(74, 21);
            this.rsrvHoursUseLabel.TabIndex = 8;
            this.rsrvHoursUseLabel.Text = "이용시간";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(1057, 318);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "~";
            // 
            // endHoursDropDown
            // 
            this.endHoursDropDown.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.endHoursDropDown.FormattingEnabled = true;
            this.endHoursDropDown.Items.AddRange(new object[] {
            "09:00",
            "10:00",
            "11:00",
            "12:00",
            "13:00",
            "14:00",
            "15:00",
            "16:00",
            "17:00",
            "18:00",
            "19:00",
            "20:00",
            "21:00"});
            this.endHoursDropDown.Location = new System.Drawing.Point(1083, 318);
            this.endHoursDropDown.Name = "endHoursDropDown";
            this.endHoursDropDown.Size = new System.Drawing.Size(81, 20);
            this.endHoursDropDown.TabIndex = 10;
            // 
            // rsrvPrsnlLabel
            // 
            this.rsrvPrsnlLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rsrvPrsnlLabel.AutoSize = true;
            this.rsrvPrsnlLabel.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rsrvPrsnlLabel.Location = new System.Drawing.Point(884, 369);
            this.rsrvPrsnlLabel.Name = "rsrvPrsnlLabel";
            this.rsrvPrsnlLabel.Size = new System.Drawing.Size(74, 21);
            this.rsrvPrsnlLabel.TabIndex = 11;
            this.rsrvPrsnlLabel.Text = "예약인원";
            // 
            // rsrvGoal
            // 
            this.rsrvGoal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rsrvGoal.Location = new System.Drawing.Point(964, 421);
            this.rsrvGoal.Name = "rsrvGoal";
            this.rsrvGoal.Size = new System.Drawing.Size(200, 21);
            this.rsrvGoal.TabIndex = 14;
            // 
            // rsrvGoalLabel
            // 
            this.rsrvGoalLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rsrvGoalLabel.AutoSize = true;
            this.rsrvGoalLabel.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rsrvGoalLabel.Location = new System.Drawing.Point(884, 421);
            this.rsrvGoalLabel.Name = "rsrvGoalLabel";
            this.rsrvGoalLabel.Size = new System.Drawing.Size(74, 21);
            this.rsrvGoalLabel.TabIndex = 13;
            this.rsrvGoalLabel.Text = "예약목적";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Location = new System.Drawing.Point(888, 234);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(276, 2);
            this.label7.TabIndex = 16;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45"});
            this.comboBox1.Location = new System.Drawing.Point(964, 370);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 20);
            this.comboBox1.TabIndex = 17;
            // 
            // selectClassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1235, 655);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.rsrvGoal);
            this.Controls.Add(this.rsrvGoalLabel);
            this.Controls.Add(this.rsrvPrsnlLabel);
            this.Controls.Add(this.endHoursDropDown);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rsrvHoursUseLabel);
            this.Controls.Add(this.startHoursDropDown);
            this.Controls.Add(this.selectClassBtn);
            this.Controls.Add(this.classNameLabel);
            this.Controls.Add(this.classNameDropDown);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.reservationBtn);
            this.Controls.Add(this.selectClassDataGrid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "selectClassForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "SpaceHub";
            this.Load += new System.EventHandler(this.selectClassForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.selectClassDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView selectClassDataGrid;
        private System.Windows.Forms.Button reservationBtn;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.ComboBox classNameDropDown;
        private System.Windows.Forms.Label classNameLabel;
        private System.Windows.Forms.Button selectClassBtn;
        private System.Windows.Forms.ComboBox startHoursDropDown;
        private System.Windows.Forms.Label rsrvHoursUseLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox endHoursDropDown;
        private System.Windows.Forms.Label rsrvPrsnlLabel;
        private System.Windows.Forms.TextBox rsrvGoal;
        private System.Windows.Forms.Label rsrvGoalLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}