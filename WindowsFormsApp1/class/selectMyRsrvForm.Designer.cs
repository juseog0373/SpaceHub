namespace WindowsFormsApp1
{
    partial class selectMyRsrvForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(selectMyRsrvForm));
            this.label1 = new System.Windows.Forms.Label();
            this.myRsrvDataGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.myRsrvDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(668, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "예약내역";
            // 
            // myRsrvDataGrid
            // 
            this.myRsrvDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.myRsrvDataGrid.Location = new System.Drawing.Point(23, 87);
            this.myRsrvDataGrid.Name = "myRsrvDataGrid";
            this.myRsrvDataGrid.ReadOnly = true;
            this.myRsrvDataGrid.RowTemplate.Height = 23;
            this.myRsrvDataGrid.Size = new System.Drawing.Size(742, 456);
            this.myRsrvDataGrid.TabIndex = 3;
            // 
            // selectMyRsrvForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 579);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.myRsrvDataGrid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "selectMyRsrvForm";
            this.Text = "SpaceHub";
            this.Load += new System.EventHandler(this.selectMyRsrvForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.myRsrvDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView myRsrvDataGrid;
    }
}