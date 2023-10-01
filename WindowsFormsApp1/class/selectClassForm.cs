using MySql.Data.MySqlClient;
using Org.BouncyCastle.Utilities.Collections;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static dbConnectSpace.dbConnection; //dbConnection 임포트
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using UserDAO;

namespace WindowsFormsApp1
{
    public partial class selectClassForm : Form
    {
        public selectClassForm()
        {
            InitializeComponent();
        }

        private DataGridViewRow selectedClassRow;
        MySqlCommand cmd = null;
        MySqlConnection conn = null;


        private void selectClassBtn_Click(object sender, EventArgs e)
        {
            try
            {
                conn = mysqlConnect();
                conn.Open();

                string sql = "";

                string classSearch = classNameDropDown.Text;

                if (classSearch.Equals("전체"))
                {
                    sql = string.Format("SELECT classCode '강의실 코드', className '강의실 이름', classFloor '강의실 층수', classLoca '강의실 위치', classMax '강의실 수용 인원', classInfo '강의실 정보' FROM classTbl ORDER BY classFloor DESC ");
                }
                else
                {
                    string[] classSearchs = classSearch.Split(' ');

                    string classLoca = classSearchs[0].Trim();
                    string classFloor = classSearchs[1].Substring(0, 1);

                    sql = string.Format("SELECT classCode '강의실 코드', className '강의실 이름', classFloor '강의실 층수', classLoca '강의실 위치', classMax '강의실 수용 인원', classInfo '강의실 정보' FROM classTbl WHERE classLoca = '{0}' AND classFloor = '{1}'", classLoca, classFloor);
                }

                cmd = new MySqlCommand(sql, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

                DataTable table = new DataTable();
                adapter.Fill(table);

                selectClassDataGrid.DataSource = table;

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void reservationBtn_Click(object sender, EventArgs e)
        {
            string userId = User.UserId;

            string rsrvDate = dateTimePicker.Value.ToString("yyyy-MM-dd HH:mm:ss");
            string rsrvPrsnl = rsrvPrsnlDropDown.Text;
            string rsrvGoal = rsrvGoalTxt.Text;
            string rsrvHoursUse = "";

            string[] startHoursArr = startHoursDropDown.Text.Split(':');
            string[] endHoursArr = endHoursDropDown.Text.Split(':');

            string startHours = startHoursArr[0].Trim();
            string endHours = endHoursArr[0].Trim();

            if (startHours.Equals("") || endHours.Equals("") || startHours == null || endHours == null)
            {
                MessageBox.Show("예약 시간을 다시 확인해주세요");
                return;
            }

            else if (rsrvPrsnl.Equals("") || rsrvPrsnl == null)
            {
                MessageBox.Show("예약 인원을 선택해주세요");
                return;
            }

            else if (rsrvGoal.Equals("") || rsrvGoal == null)
            {
                MessageBox.Show("예약 목적을 작성해주세요");
                return;
            }

            if (selectedClassRow != null)
            {
                conn = mysqlConnect();
                conn.Open();

                string classCode = selectedClassRow.Cells["강의실 코드"].Value.ToString();
                string className = selectedClassRow.Cells["강의실 이름"].Value.ToString();

                rsrvHoursUse = startHours+":00"+"~" +endHours+":00";

                string insertSql = string.Format("INSERT INTO reservationtbl(userId, classCode, rsrvDate, rsrvGoal, rsrvPrsnl, rsrvHoursUse, rsrvYN)"+
                    "VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', 'N');", userId, classCode, rsrvDate, rsrvGoal, rsrvPrsnl, rsrvHoursUse);
               
                cmd = new MySqlCommand(insertSql, conn);

                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show($"{className}({classCode}) {rsrvPrsnl}명 예약이 완료되었습니다.");
                    conn.Close();
                }
                else
                {
                    MessageBox.Show("입력하신 예약정보를 다시 확인해주세요");
                }
            }
            else
            {
                MessageBox.Show("강의실을 선택해주세요.");
            }
        }

        private void dataGridViewCell_Click(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                selectedClassRow = selectClassDataGrid.Rows[e.RowIndex];
            }
        }

        private void startHoursDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedTime = startHoursDropDown.SelectedItem.ToString();

            // time2 콤보 박스를 초기화하여 선택된 시간 이후의 값을 추가합니다.
            endHoursDropDown.Items.Clear();

            // 시간 형식을 TimeSpan으로 파싱하여 선택된 시간 이후의 시간을 계산합니다.
            TimeSpan selectedTimeSpan = TimeSpan.Parse(selectedTime);

            // 1시간을 나타내는 TimeSpan을 생성합니다.
            TimeSpan oneHour = TimeSpan.FromHours(1);

            // 선택된 시간 이후 1시간 이상인 시간 옵션을 추가합니다.
            foreach (string timeOption in startHoursDropDown.Items)
            {
                TimeSpan timeOptionTimeSpan = TimeSpan.Parse(timeOption);
                if (timeOptionTimeSpan >= selectedTimeSpan + oneHour)
                {
                    endHoursDropDown.Items.Add(timeOption);
                }
            }
        }

        private void selectClassForm_Load(object sender, EventArgs e)
        {

        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            User.UserId = "";

            this.Close();
            MessageBox.Show("로그아웃 되었습니다.");


            userLoginForm loginForm = new userLoginForm();
            loginForm.Show();
        }
    }
}
