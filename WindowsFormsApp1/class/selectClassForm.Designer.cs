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
            this.logoutBtn = new System.Windows.Forms.Button();
            this.classSelectPageBox = new System.Windows.Forms.GroupBox();
            this.rsrvPrsnlDropDown = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.rsrvGoalTxt = new System.Windows.Forms.TextBox();
            this.rsrvGoalLabel = new System.Windows.Forms.Label();
            this.rsrvPrsnlLabel = new System.Windows.Forms.Label();
            this.endHoursDropDown = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rsrvHoursUseLabel = new System.Windows.Forms.Label();
            this.startHoursDropDown = new System.Windows.Forms.ComboBox();
            this.selectClassBtn = new System.Windows.Forms.Button();
            this.classNameLabel = new System.Windows.Forms.Label();
            this.classNameDropDown = new System.Windows.Forms.ComboBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.reservationBtn = new System.Windows.Forms.Button();
            this.selectClassDataGrid = new System.Windows.Forms.DataGridView();
            this.myPageBtn = new System.Windows.Forms.Button();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.classSelectPageBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selectClassDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // logoutBtn
            // 
            this.logoutBtn.AllowDrop = true;
            this.logoutBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.logoutBtn.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.logoutBtn.Location = new System.Drawing.Point(1732, 35);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(75, 23);
            this.logoutBtn.TabIndex = 18;
            this.logoutBtn.Text = "로그아웃";
            this.logoutBtn.UseVisualStyleBackColor = true;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // classSelectPageBox
            // 
            this.classSelectPageBox.Controls.Add(this.rsrvPrsnlDropDown);
            this.classSelectPageBox.Controls.Add(this.label7);
            this.classSelectPageBox.Controls.Add(this.rsrvGoalTxt);
            this.classSelectPageBox.Controls.Add(this.rsrvGoalLabel);
            this.classSelectPageBox.Controls.Add(this.rsrvPrsnlLabel);
            this.classSelectPageBox.Controls.Add(this.endHoursDropDown);
            this.classSelectPageBox.Controls.Add(this.label3);
            this.classSelectPageBox.Controls.Add(this.rsrvHoursUseLabel);
            this.classSelectPageBox.Controls.Add(this.startHoursDropDown);
            this.classSelectPageBox.Controls.Add(this.selectClassBtn);
            this.classSelectPageBox.Controls.Add(this.classNameLabel);
            this.classSelectPageBox.Controls.Add(this.classNameDropDown);
            this.classSelectPageBox.Controls.Add(this.dateTimePicker);
            this.classSelectPageBox.Controls.Add(this.reservationBtn);
            this.classSelectPageBox.Controls.Add(this.selectClassDataGrid);
            this.classSelectPageBox.Location = new System.Drawing.Point(31, 64);
            this.classSelectPageBox.Name = "classSelectPageBox";
            this.classSelectPageBox.Size = new System.Drawing.Size(1814, 863);
            this.classSelectPageBox.TabIndex = 19;
            this.classSelectPageBox.TabStop = false;
            this.classSelectPageBox.Text = "강의실 예약";
            // 
            // rsrvPrsnlDropDown
            // 
            this.rsrvPrsnlDropDown.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rsrvPrsnlDropDown.FormattingEnabled = true;
            this.rsrvPrsnlDropDown.Items.AddRange(new object[] {
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
            this.rsrvPrsnlDropDown.Location = new System.Drawing.Point(1457, 590);
            this.rsrvPrsnlDropDown.Name = "rsrvPrsnlDropDown";
            this.rsrvPrsnlDropDown.Size = new System.Drawing.Size(200, 20);
            this.rsrvPrsnlDropDown.TabIndex = 47;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Location = new System.Drawing.Point(1381, 361);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(276, 2);
            this.label7.TabIndex = 46;
            // 
            // rsrvGoalTxt
            // 
            this.rsrvGoalTxt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rsrvGoalTxt.Location = new System.Drawing.Point(1457, 641);
            this.rsrvGoalTxt.Name = "rsrvGoalTxt";
            this.rsrvGoalTxt.Size = new System.Drawing.Size(200, 21);
            this.rsrvGoalTxt.TabIndex = 45;
            // 
            // rsrvGoalLabel
            // 
            this.rsrvGoalLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rsrvGoalLabel.AutoSize = true;
            this.rsrvGoalLabel.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rsrvGoalLabel.Location = new System.Drawing.Point(1377, 641);
            this.rsrvGoalLabel.Name = "rsrvGoalLabel";
            this.rsrvGoalLabel.Size = new System.Drawing.Size(74, 21);
            this.rsrvGoalLabel.TabIndex = 44;
            this.rsrvGoalLabel.Text = "예약목적";
            // 
            // rsrvPrsnlLabel
            // 
            this.rsrvPrsnlLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rsrvPrsnlLabel.AutoSize = true;
            this.rsrvPrsnlLabel.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rsrvPrsnlLabel.Location = new System.Drawing.Point(1377, 589);
            this.rsrvPrsnlLabel.Name = "rsrvPrsnlLabel";
            this.rsrvPrsnlLabel.Size = new System.Drawing.Size(74, 21);
            this.rsrvPrsnlLabel.TabIndex = 43;
            this.rsrvPrsnlLabel.Text = "예약인원";
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
            this.endHoursDropDown.Location = new System.Drawing.Point(1576, 538);
            this.endHoursDropDown.Name = "endHoursDropDown";
            this.endHoursDropDown.Size = new System.Drawing.Size(81, 20);
            this.endHoursDropDown.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(1550, 538);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 21);
            this.label3.TabIndex = 40;
            this.label3.Text = "~";
            // 
            // rsrvHoursUseLabel
            // 
            this.rsrvHoursUseLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rsrvHoursUseLabel.AutoSize = true;
            this.rsrvHoursUseLabel.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rsrvHoursUseLabel.Location = new System.Drawing.Point(1377, 537);
            this.rsrvHoursUseLabel.Name = "rsrvHoursUseLabel";
            this.rsrvHoursUseLabel.Size = new System.Drawing.Size(74, 21);
            this.rsrvHoursUseLabel.TabIndex = 39;
            this.rsrvHoursUseLabel.Text = "이용시간";
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
            this.startHoursDropDown.Location = new System.Drawing.Point(1457, 538);
            this.startHoursDropDown.Name = "startHoursDropDown";
            this.startHoursDropDown.Size = new System.Drawing.Size(81, 20);
            this.startHoursDropDown.TabIndex = 42;
            // 
            // selectClassBtn
            // 
            this.selectClassBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.selectClassBtn.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.selectClassBtn.Location = new System.Drawing.Point(1381, 87);
            this.selectClassBtn.Name = "selectClassBtn";
            this.selectClassBtn.Size = new System.Drawing.Size(276, 84);
            this.selectClassBtn.TabIndex = 38;
            this.selectClassBtn.Text = "조회";
            this.selectClassBtn.UseVisualStyleBackColor = true;
            this.selectClassBtn.Click += new System.EventHandler(this.selectClassBtn_Click);
            // 
            // classNameLabel
            // 
            this.classNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.classNameLabel.AutoSize = true;
            this.classNameLabel.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.classNameLabel.Location = new System.Drawing.Point(1377, 34);
            this.classNameLabel.Name = "classNameLabel";
            this.classNameLabel.Size = new System.Drawing.Size(118, 21);
            this.classNameLabel.TabIndex = 37;
            this.classNameLabel.Text = "강의실 층 선택";
            // 
            // classNameDropDown
            // 
            this.classNameDropDown.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.classNameDropDown.FormattingEnabled = true;
            this.classNameDropDown.Items.AddRange(new object[] {
            "전체",
            "전산관 5층",
            "전산관 4층",
            "전산관 3층",
            "전산관 2층",
            "임곡관 2층",
            "임곡관 1층"});
            this.classNameDropDown.Location = new System.Drawing.Point(1501, 35);
            this.classNameDropDown.Name = "classNameDropDown";
            this.classNameDropDown.Size = new System.Drawing.Size(156, 20);
            this.classNameDropDown.TabIndex = 36;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateTimePicker.Location = new System.Drawing.Point(1381, 485);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(276, 21);
            this.dateTimePicker.TabIndex = 35;
            // 
            // reservationBtn
            // 
            this.reservationBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.reservationBtn.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.reservationBtn.Location = new System.Drawing.Point(1381, 704);
            this.reservationBtn.Name = "reservationBtn";
            this.reservationBtn.Size = new System.Drawing.Size(276, 139);
            this.reservationBtn.TabIndex = 34;
            this.reservationBtn.Text = "예약";
            this.reservationBtn.UseVisualStyleBackColor = true;
            this.reservationBtn.Click += new System.EventHandler(this.reservationBtn_Click);
            // 
            // selectClassDataGrid
            // 
            this.selectClassDataGrid.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.selectClassDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.selectClassDataGrid.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.selectClassDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.selectClassDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.selectClassDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.selectClassDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.selectClassDataGrid.Location = new System.Drawing.Point(183, 35);
            this.selectClassDataGrid.Name = "selectClassDataGrid";
            this.selectClassDataGrid.ReadOnly = true;
            this.selectClassDataGrid.RowTemplate.Height = 23;
            this.selectClassDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.selectClassDataGrid.Size = new System.Drawing.Size(1161, 808);
            this.selectClassDataGrid.TabIndex = 33;
            this.selectClassDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.selectDataGridViewCell_Click);
            // 
            // myPageBtn
            // 
            this.myPageBtn.Location = new System.Drawing.Point(31, 22);
            this.myPageBtn.Name = "myPageBtn";
            this.myPageBtn.Size = new System.Drawing.Size(149, 23);
            this.myPageBtn.TabIndex = 21;
            this.myPageBtn.Text = "내 예약 조회";
            this.myPageBtn.UseVisualStyleBackColor = true;
            this.myPageBtn.Click += new System.EventHandler(this.myPageBtn_Click);
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.userNameLabel.Location = new System.Drawing.Point(1581, 35);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(128, 20);
            this.userNameLabel.TabIndex = 23;
            this.userNameLabel.Text = "test님 환영합니다";
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // selectClassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1857, 939);
            this.Controls.Add(this.userNameLabel);
            this.Controls.Add(this.myPageBtn);
            this.Controls.Add(this.classSelectPageBox);
            this.Controls.Add(this.logoutBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "selectClassForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "SpaceHub";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.selectClassForm_Load);
            this.classSelectPageBox.ResumeLayout(false);
            this.classSelectPageBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selectClassDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.GroupBox classSelectPageBox;
        private System.Windows.Forms.ComboBox rsrvPrsnlDropDown;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox rsrvGoalTxt;
        private System.Windows.Forms.Label rsrvGoalLabel;
        private System.Windows.Forms.Label rsrvPrsnlLabel;
        private System.Windows.Forms.ComboBox endHoursDropDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label rsrvHoursUseLabel;
        private System.Windows.Forms.ComboBox startHoursDropDown;
        private System.Windows.Forms.Button selectClassBtn;
        private System.Windows.Forms.Label classNameLabel;
        private System.Windows.Forms.ComboBox classNameDropDown;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button reservationBtn;
        private System.Windows.Forms.DataGridView selectClassDataGrid;
        private System.Windows.Forms.Button myPageBtn;
        private System.Windows.Forms.Label userNameLabel;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
    }
}