using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserDTO;
using static dbConnectSpace.dbConnection; //dbConnection 임포트
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WindowsFormsApp1
{
    public partial class regClassForm : Form
    {
        private adminForm adminForm;  // adminForm을 참조하기 위한 변수

        public regClassForm(adminForm adminForm)
        {
            InitializeComponent();
            this.adminForm = adminForm;
        }

        MySqlConnection conn = null;

        private void regBtn_Click(object sender, EventArgs e)
        {
            conn = mysqlConnect();
            conn.Open();

            string classCode = classCodeTxt.Text;
            string className = classNameTxt.Text;
            string classFloor = classFloorTxt.Text;
            string classLoca = classLocaTxt.Text;
            string classMax = classMaxTxt.Text;
            string classInfo = classInfoTxt.Text;

            string RegSql = string.Format("INSERT INTO classTbl (classCode, className, classFloor, classLoca,classMax,classInfo) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}');"
                , classCode, className, classFloor, classLoca, classMax, classInfo);

            MySqlCommand command = new MySqlCommand(RegSql, conn);

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("등록 완료 되었습니다.");
                // 등록 후 adminForm의 DataGridView 갱신
                adminForm.RefreshDataGridView();

                conn.Close();
                Close();
            }
            else
            {
                MessageBox.Show("입력하신 정보를 확인해주세요.");
            }
        }

        private void regClassForm_Load(object sender, EventArgs e)
        {

        }
    }
}
