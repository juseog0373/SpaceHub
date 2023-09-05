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
using static dbConnectSpace.dbConnection;

namespace WindowsFormsApp1
{
    public partial class userAccountForm : Form
    {
        public userAccountForm()
        {
            InitializeComponent();
        }

        private void userAccountForm_Load(object sender, EventArgs e)
        {

        }

        private void accountActionBtn_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection conn = mysqlConnect();

                conn.Open();

                string userId = userIdTxt.Text;
                string userPwd = userPwdTxt.Text;
                string userName = userName123Txt.Text;

                string insertQuery = "INSERT INTO userTbl (name, id, password) VALUES ('" + userName + "', '" + userId + "', '" + userPwd + "');";
                MySqlCommand command = new MySqlCommand(insertQuery, conn);

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show(userName + "님 회원가입 완료, 사용할 아이디는 " + userId + "입니다.");
                    conn.Close();
                    Close();
                }
                else
                {
                    MessageBox.Show("비정상 입력 정보, 재확인 요망");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
