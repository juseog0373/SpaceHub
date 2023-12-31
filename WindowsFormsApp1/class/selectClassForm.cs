﻿using MySql.Data.MySqlClient;
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
using UserDTO;
using System.Diagnostics.Eventing.Reader;
using Org.BouncyCastle.Asn1.X509;
using System.Security.Cryptography;

namespace WindowsFormsApp1
{
    public partial class selectClassForm : MetroFramework.Forms.MetroForm
    {
        public selectClassForm()
        {
            InitializeComponent();
        }

        private DataGridViewRow selectedClassRow;

        MySqlCommand cmd = null;
        MySqlConnection conn = null;

        string sql = "";

        private void selectClassBtn_Click(object sender, EventArgs e)
        {
            try
            {
                conn = mysqlConnect();
                conn.Open();

                string classSearch = classNameDropDown.Text; // 검색어
                DateTime dt = dateTimePicker.Value;
                string searchDate = dt.ToString("yyyy-MM-dd");

                if (classSearch.Equals("전체"))
                {
                    sql = string.Format("SELECT " +
                          "c.classCode AS '강의실 코드', " +
                          "c.className AS '강의실 이름', " +
                          "c.classFloor AS '강의실 층수', " +
                          "c.classLoca AS '강의실 위치', " +
                          "c.classMax AS '강의실 수용인원', " +
                          "IFNULL(c.classMax - SUM(CASE WHEN r.rsrvYN = 'N' OR r.rsrvYN = 'Y' THEN r.rsrvPrsnl ELSE 0 END), c.classMax) AS '예약 가능 인원', " +
                          "c.classInfo AS '강의실 정보' " +
                          "FROM classTbl c " +
                          "LEFT JOIN reservationtbl r ON c.classCode = r.classCode AND r.rsrvDate = '{0}' " +
                          "GROUP BY c.classCode " +
                          "HAVING IFNULL(c.classMax - SUM(CASE WHEN r.rsrvYN = 'N' OR r.rsrvYN = 'Y' THEN r.rsrvPrsnl ELSE 0 END), c.classMax) > 0 " +
                          "ORDER BY c.classFloor DESC", searchDate);
                }
                else
                {
                    string[] classSearchs = classSearch.Split(' ');

                    string classLoca = classSearchs[0].Trim();
                    string classFloor = classSearchs[1].Substring(0, 1);

                    sql = string.Format("SELECT " +
                        "c.classCode AS '강의실 코드', " +
                        "c.className AS '강의실 이름', " +
                        "c.classFloor AS '강의실 층수', " +
                        "c.classLoca AS '강의실 위치', " +
                        "c.classMax AS '강의실 수용인원', " +
                        "IFNULL(c.classMax - SUM(CASE WHEN r.rsrvYN = 'N' OR r.rsrvYN = 'Y' THEN r.rsrvPrsnl ELSE 0 END), c.classMax) AS '예약 가능 인원', " +
                        "c.classInfo AS '강의실 정보' " +
                        "FROM classTbl c " +
                        "LEFT JOIN reservationtbl r ON c.classCode = r.classCode AND r.rsrvDate = '{0}' " +
                        "WHERE c.classLoca = '{1}' AND c.classFloor = {2} " +
                        "GROUP BY c.classCode " +
                        "HAVING IFNULL(c.classMax - SUM(CASE WHEN r.rsrvYN = 'N' OR r.rsrvYN = 'Y' THEN r.rsrvPrsnl ELSE 0 END), c.classMax) > 0 " +
                        "ORDER BY c.classFloor DESC", searchDate, classLoca, classFloor);
                }

                cmd = new MySqlCommand(sql, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

                DataTable table = new DataTable();
                adapter.Fill(table);

                selectClassDataGrid.DataSource = table;

                foreach (DataGridViewColumn item in selectClassDataGrid.Columns)
                {
                    item.SortMode = DataGridViewColumnSortMode.NotSortable;
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void reservationBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string userId = User.UserId;

                string rsrvDate = dateTimePicker.Value.ToString("yyyy-MM-dd");              // 예약 일자
                string rsrvPrsnl = rsrvPrsnlDropDown.Text;                                  // 예약 인원
                string rsrvGoal = rsrvGoalTxt.Text;                                         // 예약 목적
                string startHours = startHoursDropDown.Text;                                // 예약 시작 시간
                string endHours = endHoursDropDown.Text;                                    // 예약 끝 시간
                string classCode = "";                                                      // 강의실 코드
                string className = "";                                                      // 강의실 이름
                string rsrvHoursUse = startHours + "~" + endHours;                          // 강의실 이용 시간

                if (startHours.Equals("") || endHours.Equals("") || startHours == null || endHours == null)
                {
                    //예약 시작이나 끝 시간에 값이 없을 경우 메세지 박스 출력후 리턴
                    MessageBox.Show("예약 시간을 다시 확인해주세요");
                    return;
                }

                else if (rsrvPrsnl.Equals("") || rsrvPrsnl == null)
                {
                    //예약 인원의 값이 없을 경우
                    MessageBox.Show("예약 인원을 선택해주세요");
                    return;
                }

                else if (rsrvGoal.Equals("") || rsrvGoal == null)
                {
                    //예약 목적의 값이 없을 경우
                    MessageBox.Show("예약 목적을 작성해주세요");
                    return;
                }

                // 만약 선택한 강의실이 있는 경우
                if (selectedClassRow != null)
                {
                    conn = mysqlConnect();
                    conn.Open();

                    // 선택한 강의실의 코드 및 이름 가져오기
                    classCode = selectedClassRow.Cells["강의실 코드"].Value.ToString(); // 사용자가 선택한 강의실의 코드
                    className = selectedClassRow.Cells["강의실 이름"].Value.ToString(); // 사용자가 선택한 강의실의 이름

                    // 예약 정보를 reservationtbl 테이블에 넣는 INSERT문 순서대로 학번, 강의실명, 일자, 목적, 인원, 이용시간이 넣어진다.
                    sql = string.Format("INSERT INTO reservationtbl(userId, classCode, rsrvDate, rsrvGoal, rsrvPrsnl, rsrvHoursUse, rsrvYN)" +
                       "VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', 'N');", userId, classCode, rsrvDate, rsrvGoal, rsrvPrsnl, rsrvHoursUse);

                    cmd = new MySqlCommand(sql, conn);

                    // 쿼리 실행 결과가 1인 경우, 예약 완료 메시지 표시하고 데이터베이스 연결 닫기
                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        // 사용자 입력값 가져와 완료 메세지 출력
                        MessageBox.Show($"{className}({classCode}) {rsrvPrsnl}명 예약이 완료되었습니다."); 
                        conn.Close();
                    }
                    else
                    {
                        MessageBox.Show("입력하신 예약정보를 다시 확인해주세요.");
                    }
                }
                else
                {
                    MessageBox.Show("강의실을 선택해주세요.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void selectDataGridViewCell_Click(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                selectedClassRow = selectClassDataGrid.Rows[e.RowIndex];
            }   

            if(selectedClassRow != null)
            {
                string availPrsnl = selectedClassRow.Cells["예약 가능 인원"].Value.ToString(); //예약 가능 인원 셀에 있는 value 값을 가져와 문자열로 변환 후 변수에 저장

                rsrvPrsnlDropDown.Items.Clear(); // 예약 가능한 인원을 나타내는 콤보박스를 초기화
                int availPrsnlNum = int.Parse(availPrsnl); // 정수형으로 형 변환

                for (int i = 1; i <= availPrsnlNum; i++)  // 1부터 availPrsnlNum 까지의 숫자를 콤보박스에 추가
                {
                    rsrvPrsnlDropDown.Items.Add(i);
                }
            }
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            User.UserId = "";

            MessageBox.Show("로그아웃 되었습니다.");
            this.Close();

            userLoginForm loginForm = new userLoginForm();
            loginForm.Show();
        }

        private void selectClassForm_Load(object sender, EventArgs e)
        {
            classNameDropDown.SelectedIndex = 0;

            userNameLabel.Text = User.UserName + "님 환영합니다";
        }


        private void myPageBtn_Click(object sender, EventArgs e)
        {
            // 예약 조회 버튼 클릭시 예약내역 폼 화면 출력

            selectMyRsrvForm selectMyRsrvForm = new selectMyRsrvForm(); // selectMyRsrvForm의 인스턴스 생성
            selectMyRsrvForm.Show(); // selectMyRsrvForm을 표시
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

        private void selectClassDataGrid_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            foreach (DataGridViewColumn item in selectClassDataGrid.Columns)
            {
                item.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }
    }
}