using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class adminForm : Form
    {
        public adminForm()
        {
            InitializeComponent();
        }

        private void adminForm_Load(object sender, EventArgs e)
        {

        }

        


        private void 예약미승인건조회ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 예약 미승인건 조회 쿼리 입력
            label1.Visible = true;
            comboBox1.Visible = true;
            button5.Visible = true;
        }

        private void 예약승인건조회ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 예약 승인건 조회 쿼리 입력
            label1.Visible = true;
            comboBox1.Visible = true;
            button5.Visible = true;
        }

        private void 강의실조회ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 강의실 조회 쿼리 입력
            label1.Visible = false;
            comboBox1.Visible = false;
            button5.Visible = true;
        }

        private void 회원조회ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            comboBox1.Visible = false;
            button5.Visible = false;
            dataGridView1.ReadOnly = true;
        }
    }
}
