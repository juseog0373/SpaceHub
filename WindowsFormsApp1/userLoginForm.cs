using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dbConnectSpace;
using MySql.Data.MySqlClient; // SQL 연동을 위한 using
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static dbConnectSpace.dbConnection; //dbConnection 임포트


namespace WindowsFormsApp1
{
    public partial class userLoginForm : Form
    {
        public userLoginForm()
        {
            InitializeComponent();
        }

        private void userLoginForm_Load(object sender, EventArgs e)
        {

        }

        private void accountBtn_Click(object sender, EventArgs e)
        {
            userAccountForm userAccountForm = new userAccountForm();
            userAccountForm.ShowDialog(); // 다른 폼 창을 불러오는 (include)
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection conn = mysqlConnect();
                conn.Open();

                int loginStatus = 0;

                string userId = userIdTxt.Text;
                string userPw = userPwTxt.Text;
                string userName = "";

                string sql = string.Format("SELECT * FROM userTbl WHERE userId = '{0}' AND userPw = '{1}'", userId, userPw);

                MySqlCommand Selectcommand = new MySqlCommand(sql, conn);

                MySqlDataReader userAccount = Selectcommand.ExecuteReader();

                while (userAccount.Read())
                {
                    userName = (string)userAccount["userName"];

                    if (userId == (string)userAccount["userId"] && userPw == (string)userAccount["userPw"])
                    {
                        loginStatus = 1;
                    }
                }
                conn.Close();

                if (loginStatus == 1)
                {
                    MessageBox.Show(userName + "님 환영합니다.");
                }
                else
                {
                    MessageBox.Show("입력한 아이디 또는 비밀번호를 확인해 주세요.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
