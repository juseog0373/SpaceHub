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
                string userPw = userPwTxt.Text;
                string userName = userNameTxt.Text;

                string idCheckSql = string.Format("SELECT COUNT(userId) FROM userTbl WHERE userId = '{0}'", userId);

                MySqlCommand command = new MySqlCommand(idCheckSql, conn);
                MySqlDataReader data = command.ExecuteReader();

                if (data.Read())
                {
                    int idCheck = Convert.ToInt32(data.GetString(0));

                    if (idCheck > 0)
                    {
                        MessageBox.Show("중복된 아이디입니다.\n다른 아이디를 사용해주세요.");
                    }
                    else
                    {
                        data.Close();

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
