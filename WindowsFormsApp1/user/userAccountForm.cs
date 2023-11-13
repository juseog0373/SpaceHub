using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
        private bool ValidateId(string userId)
        {
            string regId = "^[0-9]{1,9}$";
            return Regex.IsMatch(userId, regId);
        }

        private bool ValidatePassword(string userPw)
        {
            string regPw = "^(?=.*[a-z])(?=.*\\d)(?=.*[^\\da-zA-Z]).{8,}$";
            return Regex.IsMatch(userPw, regPw);
        }

        private bool ValidateName(string userName)
        {
            string regName = "^[가-힣]+$";
            return Regex.IsMatch(userName, regName);
        }

        private void accountActionBtn_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection conn = mysqlConnect();

                conn.Open();

                string userId = userIdTxt.Text;
                string userPw = userPwTxt.Text;
                string userName = userNameTxt.Text;



                // 아이디 유효성 검사
                if (!ValidateId(userId))
                {
                    MessageBox.Show("올바른 아이디 형식이 아닙니다.");
                    return;
                }

                // 비밀번호 유효성 검사
                if (!ValidatePassword(userPw))
                {
                    MessageBox.Show("올바른 비밀번호 형식이 아닙니다.");
                    return;
                }

                // 이름 유효성 검사
                if (!ValidateName(userName))
                {
                    MessageBox.Show("올바른 이름 형식이 아닙니다.");
                    return;
                }

                string idCheckSql = string.Format("SELECT COUNT(userId) FROM userTbl WHERE userId = '{0}'", userId);

                MySqlCommand command = new MySqlCommand(idCheckSql, conn);
                MySqlDataReader mdr = command.ExecuteReader();

                if (mdr.Read())
                {
                    int idCheck = Convert.ToInt32(mdr.GetString(0));

                    if (idCheck > 0)
                    {
                        MessageBox.Show("이미 등록된 학번입니다.");
                    }

                    else
                    {
                        mdr.Close();

                        string accountSql = string.Format("INSERT INTO userTbl (userId, userPw, userName) VALUES ('{0}', '{1}', '{2}');", userId, userPw, userName);

                        MySqlCommand command1 = new MySqlCommand(accountSql, conn);

                        if (command1.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show(userName + "님 회원가입이 완료되었습니다.");
                            conn.Close();
                            Close();
                        }
                        else
                        {
                            MessageBox.Show("입력하신 정보를 확인해주세요.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("데이터를 읽을 수 없습니다.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

     
    }
}