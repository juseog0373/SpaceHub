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
using static dbConnectSpace.dbConnection; //dbConnection 임포트
using UserDTO;

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
            userIdTxt.Text = Properties.Settings.Default.loginIdSave;
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

                string sql = string.Format("SELECT * FROM userTbl WHERE userId = '{0}' AND userPw = '{1}'", userId, userPw);

                MySqlCommand command = new MySqlCommand(sql, conn);
                MySqlDataReader mdr = command.ExecuteReader();


                while (mdr.Read())
                {
                    if (userId == (string)mdr["userId"] && userPw == (string)mdr["userPw"])
                    {
                        loginStatus = 1;
                    }
                }
                if (loginStatus == 1)
                {
                    Properties.Settings.Default.loginIdSave = (string)mdr["userId"];

                    User.UserName = mdr.GetString("userName");
                    User.UserId = (string)mdr["userId"];

                    MessageBox.Show(User.UserName + "님 환영합니다.");

                    selectClassForm selectClassForm = new selectClassForm();
                    selectClassForm.Tag = this;
                    selectClassForm.Show();
                    this.Hide();
                }
                else if(userId == "")
                {
                    MessageBox.Show("학번을 입력해주세요");
                    this.userIdTxt.Focus();
                }
                else if (userPw == "")
                {
                    MessageBox.Show("비밀번호를 입력해주세요");
                    this.userPwTxt.Focus();
                }
                else
                {
                    MessageBox.Show("학번 또는 비밀번호가 맞지 않습니다.");
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
