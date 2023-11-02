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
            this.myRsrvDataGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.myRsrvDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // myRsrvDataGrid
            // 
            this.myRsrvDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.myRsrvDataGrid.Location = new System.Drawing.Point(12, 106);
            this.myRsrvDataGrid.Name = "myRsrvDataGrid";
            this.myRsrvDataGrid.RowTemplate.Height = 23;
            this.myRsrvDataGrid.Size = new System.Drawing.Size(609, 456);
            this.myRsrvDataGrid.TabIndex = 1;
            // 
            // selectMyRsrvForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 589);
            this.Controls.Add(this.myRsrvDataGrid);
            this.Name = "selectMyRsrvForm";
            this.Text = "spaceHub";
            this.Load += new System.EventHandler(this.selectMyRsrvForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.myRsrvDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView myRsrvDataGrid;
    }
}