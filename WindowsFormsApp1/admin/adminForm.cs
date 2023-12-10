using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
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
using UserDTO;
using static dbConnectSpace.dbConnection;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class adminForm : MetroFramework.Forms.MetroForm
    {
        MySqlCommand cmd = new MySqlCommand();  // 클래스 레벨에서 선언

        public adminForm()
        {
            InitializeComponent();
        }

        MySqlConnection conn = null;
        string sql = "";

        private void rsrvCodeDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 드롭다운 선택 시 이벤트
            selectRsrvToolStripMenuItem_Click(sender, e);
        }

        private void selectRsrvToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 특정 UI 요소들의 표시 여부를 true로 설정
            rsrvLabel.Visible = true;
            rsrvCodeDropdown.Visible = true;
            yesBtn.Visible = true;
            noBtn.Visible = true;

            // adminDataGrid의 모든 열을 지움
            adminDataGrid.Columns.Clear();

            // 새로운 DataGridViewCheckBoxColumn을 생성
            DataGridViewCheckBoxColumn dgvCmb = new DataGridViewCheckBoxColumn();
            dgvCmb.ValueType = typeof(bool); // 체크박스 열의 값 타입을 불리언으로 설정
            dgvCmb.Name = "Chk"; // 체크박스 열의 이름을 "Chk"로 설정
            dgvCmb.HeaderText = "선택"; // 체크박스 열의 헤더 텍스트를 "선택"으로 설정
            adminDataGrid.Columns.Add(dgvCmb); // 체크박스 열을 adminDataGrid에 추가
            adminDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // adminDataGrid의 선택 모드를 전체 행 선택으로 설정

            string rsrvSearch = rsrvCodeDropdown.Text; // rsrvCodeDropdown에서 텍스트를 가져옴

            conn = mysqlConnect();
            conn.Open();

            try
            {
                if (rsrvSearch.Equals("전체"))
                {
                    sql = string.Format("SELECT" +
                        " r.rsrvSeq '예약번호'," +
                        " r.userId '학번'," +
                        " u.userName '예약자명'," +
                        " r.classCode '강의실 코드'," +
                        " r.rsrvDate '예약 날짜', " +
                        " r.rsrvGoal '예약 목적', " +
                        " r.rsrvPrsnl '예약 인원', " +
                        " r.rsrvHoursUse '이용 시간', " +
                        "CASE" +
                            " WHEN r.rsrvYN = 'Y'" +
                            " THEN '승인 완료'" +
                            " WHEN r.rsrvYN = 'N'" +
                            " THEN '승인 대기'" +
                            " WHEN r.rsrvYN = 'R'" +
                            " THEN '승인 거절'" +
                            " END AS '예약 상태'" +
                        " FROM reservationtbl r, userTbl u" +
                        " WHERE" +
                            " u.userId = r.userId" +
                        " ORDER BY r.rsrvDate DESC"
                    );
                }
                else if (rsrvSearch.Equals("승인 대기"))
                {
                    sql = string.Format("SELECT" +
                        " r.rsrvSeq '예약번호'," +
                        " r.userId '학번'," +
                        " u.userName '예약자명'," +
                        " r.classCode '강의실 코드'," +
                        " r.rsrvDate '예약 날짜', " +
                        " r.rsrvGoal '예약 목적', " +
                        " r.rsrvPrsnl '예약 인원', " +
                        " r.rsrvHoursUse '이용 시간', " +
                        "CASE" +
                            " WHEN r.rsrvYN = 'Y'" +
                            " THEN '승인 완료'" +
                            " WHEN r.rsrvYN = 'N'" +
                            " THEN '승인 대기'" +
                            " WHEN r.rsrvYN = 'R'" +
                            " THEN '승인 거절'" +
                            " END AS '예약 상태'" +
                        " FROM reservationtbl r, userTbl u" +
                        " WHERE" +
                            " u.userId = r.userId" +
                        " AND" +
                            " r.rsrvYN = 'N'" +
                        " ORDER BY r.rsrvDate DESC"
                    );
                }
                else if (rsrvSearch.Equals("승인 완료"))
                {
                    sql = string.Format("SELECT" +
                        " r.rsrvSeq '예약번호'," +
                        " r.userId '학번'," +
                        " u.userName '예약자명'," +
                        " r.classCode '강의실 코드'," +
                        " r.rsrvDate '예약 날짜', " +
                        " r.rsrvGoal '예약 목적', " +
                        " r.rsrvPrsnl '예약 인원', " +
                        " r.rsrvHoursUse '이용 시간', " +
                        "CASE" +
                            " WHEN r.rsrvYN = 'Y'" +
                            " THEN '승인 완료'" +
                            " WHEN r.rsrvYN = 'N'" +
                            " THEN '승인 대기'" +
                            " WHEN r.rsrvYN = 'R'" +
                            " THEN '승인 거절'" +
                            " END AS '예약 상태'" +
                        " FROM reservationtbl r, userTbl u" +
                        " WHERE" +
                            " u.userId = r.userId" +
                        " AND" +
                            " r.rsrvYN = 'Y'" +
                        " ORDER BY r.rsrvDate DESC"
                    );
                }
                else if (rsrvSearch.Equals("승인 거절"))
                {
                    sql = string.Format("SELECT" +
                        " r.rsrvSeq '예약번호'," +
                        " r.userId '학번'," +
                        " u.userName '예약자명'," +
                        " r.classCode '강의실 코드'," +
                        " r.rsrvDate '예약 날짜', " +
                        " r.rsrvGoal '예약 목적', " +
                        " r.rsrvPrsnl '예약 인원', " +
                        " r.rsrvHoursUse '이용 시간', " +
                        "CASE" +
                            " WHEN r.rsrvYN = 'Y'" +
                            " THEN '승인 완료'" +
                            " WHEN r.rsrvYN = 'N'" +
                            " THEN '승인 대기'" +
                            " WHEN r.rsrvYN = 'R'" +
                            " THEN '승인 거절'" +
                            " END AS '예약 상태'" +
                        " FROM reservationtbl r, userTbl u" +
                        " WHERE" +
                            " u.userId = r.userId" +
                        " AND" +
                            " r.rsrvYN = 'R'" +
                        " ORDER BY r.rsrvDate DESC"
                    );
                }

                cmd = new MySqlCommand(sql, conn);

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

                DataTable table = new DataTable();
                adapter.Fill(table);

                adminDataGrid.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show("조회 중 오류가 발생했습니다\n오류 메세지: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void yesBtn_Click(object sender, EventArgs e)
        {
            try
            {
                conn = mysqlConnect();
                conn.Open();

                // 선택된 예약번호들을 저장할 리스트
                List<int> selectedReservationSeqList = new List<int>();

                foreach (DataGridViewRow row in adminDataGrid.Rows)
                {
                    DataGridViewCheckBoxCell chk = row.Cells["Chk"] as DataGridViewCheckBoxCell;

                    if (chk.Value != null && (bool)chk.Value)
                    {
                        int reservationSeq = Convert.ToInt32(row.Cells["예약번호"].Value);
                        selectedReservationSeqList.Add(reservationSeq);
                    }
                }

                // 확인 메시지 띄우기
                DialogResult result = MessageBox.Show($"예약을 승인하시겠습니까?", "예약 승인", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    foreach (int reservationSeq in selectedReservationSeqList)
                    {
                        // 예약 승인 처리
                        string updateRsrvStatusSql = string.Format(
                            "UPDATE reservationtbl SET rsrvYN = 'Y' WHERE rsrvSeq = '{0}'", reservationSeq);

                        cmd = new MySqlCommand(updateRsrvStatusSql, conn);
                        cmd.ExecuteNonQuery();

                        // 해당 예약의 classCode 가져오기
                        string getClassCodeSql = string.Format(
                            "SELECT classCode FROM reservationtbl WHERE rsrvSeq = '{0}'", reservationSeq);

                        cmd = new MySqlCommand(getClassCodeSql, conn);
                        string classCode = cmd.ExecuteScalar().ToString();

                        // 클래스의 예약 가능 인원 갱신 쿼리
                        string updateClassAvailSql = string.Format(
                            "UPDATE classTbl " +
                            "SET classAvail = classMax - ( " +
                            "SELECT IFNULL(SUM(rsrvPrsnl), 0) " +
                            "FROM reservationtbl " +
                            "WHERE classTbl.classCode = reservationtbl.classCode " +
                            "AND rsrvSeq = '{0}' " +
                            "AND rsrvYN = 'Y' " +
                            ") " +
                            "WHERE classTbl.classCode = '{1}'", reservationSeq, classCode);

                        cmd = new MySqlCommand(updateClassAvailSql, conn);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show(selectedReservationSeqList.Count + "건의 예약을 승인 하였습니다.");
                    // 예약 승인 후 다시 조회
                    selectRsrvToolStripMenuItem_Click(sender, e);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }


        private void noBtn_Click(object sender, EventArgs e)
        {
            try
            {
                conn = mysqlConnect();
                conn.Open();

                // 선택된 예약번호들을 저장할 리스트
                List<string> userSelectedSeqList = new List<string>();

                foreach (DataGridViewRow row in adminDataGrid.Rows)
                {
                    DataGridViewCheckBoxCell chk = row.Cells["Chk"] as DataGridViewCheckBoxCell;

                    if (chk.Value != null && (bool)chk.Value)
                    {
                        string rsrvSeq = row.Cells["예약번호"].Value.ToString();
                        userSelectedSeqList.Add(rsrvSeq);
                    }
                }

                // 확인 메시지 띄우기
                DialogResult result = MessageBox.Show($"{userSelectedSeqList.Count}건의 예약을 거절하시겠습니까?", "예약 거절", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // 예약 거절 처리하는 쿼리
                    foreach (string rsrvSeq in userSelectedSeqList)
                    {
                        sql = string.Format(
                            "UPDATE reservationtbl " +
                            "SET rsrvYN = 'R' " +
                            "WHERE rsrvSeq = '{0}'", rsrvSeq);

                        cmd = new MySqlCommand(sql, conn);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show(userSelectedSeqList.Count + "건의 예약을 거절하였습니다.");

                    // 예약 거절 후 다시 조회
                    selectRsrvToolStripMenuItem_Click(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }


        private void adminForm_Load(object sender, EventArgs e)
        {
            // 디폴트 값 설정
            rsrvCodeDropdown.SelectedIndex = rsrvCodeDropdown.FindStringExact("승인 대기");
            // 초기 조회 수행
            selectRsrvToolStripMenuItem_Click(sender, e);
            // 전체 화면으로 설정
            this.WindowState = FormWindowState.Maximized;
            adminDataGrid.AllowUserToAddRows = false;

            userNameLabel.Text = User.UserName + "님 환영합니다";
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            yesBtn.Visible = false;
            noBtn.Visible = false;
            rsrvLabel.Visible = false;
            rsrvCodeDropdown.Visible = false;

            // DataGridView에 있는 기존 열들을 지움
            adminDataGrid.Columns.Clear();

            // MySQL 연결 설정
            conn = mysqlConnect();
            conn.Open();

            try
            {
                sql = string.Format("SELECT u.userSeq '회원 번호', u.userId '학번', u.userPw '비밀번호', u.userName '이름'" +
                " FROM userTbl u");

                // SQL 쿼리 실행
                cmd = new MySqlCommand(sql, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

                // 쿼리 결과로 DataTable 채우기
                DataTable table = new DataTable();
                adapter.Fill(table);

                // DataGridView의 DataSource를 DataTable로 설정
                adminDataGrid.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show("조회 중 오류가 발생했습니다\n오류 메세지: " + ex.Message);
            }
            finally
            {
                // 예외 발생 여부에 관계 없이 데이터베이스 연결을 닫기 위해 finally 블록에서 처리
                conn.Close();
            }
        }

        private void classToolStripMenuItem_Click(object sender, EventArgs e)
        {
            yesBtn.Visible = false;
            noBtn.Visible = false;
            rsrvLabel.Visible = false;
            rsrvCodeDropdown.Visible = false;
        }

        private void deleteClassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            conn = mysqlConnect();
            conn.Open();

            if (adminDataGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("강의실을 선택해주세요.");
                return;
            }

            DataGridViewRow selectedRow = adminDataGrid.SelectedRows[0];
            string classSeq = selectedRow.Cells["강의실 일련번호"].Value.ToString();

            try
            {
                sql = string.Format($"DELETE FROM classTbl WHERE classSeq = {classSeq}");

                cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();

                MessageBox.Show("삭제가 완료되었습니다.");
                RefreshDataGridView();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"삭제 중 오류가 발생하였습니다.\n\n{ex.ToString()}");
            }
        }

        private void regClassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            regClassForm regclassForm = new regClassForm(this);
            regclassForm.ShowDialog(); // 다른 폼 창을 불러오는 (include)
        }

        private void selectClassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // DataGridView에 있는 기존 열들을 지움
            adminDataGrid.Columns.Clear();

            DataGridViewCheckBoxColumn dgvCmb = new DataGridViewCheckBoxColumn();
            dgvCmb.ValueType = typeof(bool);
            dgvCmb.Name = "Chk";
            dgvCmb.HeaderText = "선택";
            adminDataGrid.Columns.Add(dgvCmb);
            adminDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // MySQL 연결 설정
            conn = mysqlConnect();
            conn.Open();

            try
            {
                sql = string.Format("SELECT c.classSeq '강의실 일련번호', c.classCode '강의실 코드', c.className '강의실 이름', c.classFloor '강의실 층수', c.classLoca '강의실 위치', c.classMax '강의실 수용인원',  c.classAvail '예약 가능 인원', c.classInfo '강의실 정보'" +
                        " FROM classTbl c");

                // SQL 쿼리 실행
                cmd = new MySqlCommand(sql, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

                // 쿼리 결과로 DataTable 채우기
                DataTable table = new DataTable();
                adapter.Fill(table);

                // DataGridView의 DataSource를 DataTable로 설정
                adminDataGrid.DataSource = table;

                // 열 너비 자동 조정
                adminDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                // 각 열에 최소 너비 설정
                foreach (DataGridViewColumn column in adminDataGrid.Columns)
                {
                    column.MinimumWidth = 50; // 원하는 최소 너비로 설정
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("조회 중 오류가 발생했습니다\n오류 메세지: " + ex.Message);
            }
            finally
            {
                // 예외 발생 여부에 관계 없이 데이터베이스 연결을 닫기 위해 finally 블록에서 처리
                conn.Close();
            }
        }

        private void updateClassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (adminDataGrid.SelectedRows.Count == 0)
                {
                    MessageBox.Show("강의실을 선택해주세요.");
                    return; // 강의실이 선택되지 않았으면 더 이상 진행하지 않음
                }

                // 선택된 강의실 코드 가져오기
                DataGridViewRow selectedRow = adminDataGrid.SelectedRows[0];
                string classSeq = selectedRow.Cells["강의실 일련번호"].Value.ToString();

                updateClassForm updateClassForm = new updateClassForm(classSeq, this);
                updateClassForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void RefreshDataGridView()
        {
            // DataGridView 갱신에 필요한 코드 작성
            string selectSql = "SELECT classSeq '강의실 일련번호', classCode '강의실 코드', className '강의실 이름', classFloor '강의실 층수', classLoca '강의실 위치', classMax '강의실 수용인원', classInfo '강의실 정보' FROM classTbl";
            cmd = new MySqlCommand(selectSql, conn);

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);

            // DataGridView에 데이터 설정
            adminDataGrid.DataSource = table;

            // 열 너비 자동 조정
            adminDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            // 각 열에 최소 너비 설정
            foreach (DataGridViewColumn column in adminDataGrid.Columns)
            {
                column.MinimumWidth = 50; // 원하는 최소 너비로 설정
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
    }
}
