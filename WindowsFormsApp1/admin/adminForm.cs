using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
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
    public partial class adminForm : Form
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
            rsrvLabel.Visible = true;
            rsrvCodeDropdown.Visible = true;
            yesBtn.Visible = true;
            noBtn.Visible = true;

            adminDataGrid.Columns.Clear();

            DataGridViewCheckBoxColumn dgvCmb = new DataGridViewCheckBoxColumn();
            dgvCmb.ValueType = typeof(bool);
            dgvCmb.Name = "Chk";
            dgvCmb.HeaderText = "선택";
            adminDataGrid.Columns.Add(dgvCmb);
            adminDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            string rsrvSearch = rsrvCodeDropdown.Text;

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
                            " u.userId = r.userId"+
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
                            " u.userId = r.userId"+
                        " AND"+
                            " r.rsrvYN = 'N'"+
                        " ORDER BY r.rsrvDate DESC"
                    );
                }
                else if (rsrvSearch.Equals("예약 승인"))
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
                            " r.rsrvYN = 'Y'"+
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
                            " r.rsrvYN = 'R'"+
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
                MessageBox.Show("조회 중 오류가 발생했습니다\n오류 메세지: " +ex.Message);
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

                // 선택된 예약번호들을 문자열로 변환
                string selectedReservationSeqs = string.Join(", ", selectedReservationSeqList);

                // 확인 메시지 띄우기
                DialogResult result = MessageBox.Show($"예약번호: {selectedReservationSeqs} \n예약을 승인하시겠습니까?", "예약 승인", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // 예약 승인 처리하는 쿼리
                    foreach (int reservationSeq in selectedReservationSeqList)
                    {
                        sql = $"UPDATE reservationTbl SET rsrvYN = 'Y' WHERE rsrvSeq = {reservationSeq}";

                        cmd = new MySqlCommand(sql, conn);
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

                // 선택된 예약번호들을 문자열로 변환
                string selectedReservationSeqs = string.Join(", ", selectedReservationSeqList);

                // 확인 메시지 띄우기
                DialogResult result = MessageBox.Show($"예약번호 {selectedReservationSeqs} \n예약을 거절하시겠습니까?", "예약 거절", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // 예약 거절 처리하는 쿼리
                    foreach (int reservationSeq in selectedReservationSeqList)
                    {
                        sql = $"UPDATE reservationtbl SET rsrvYN = 'R' WHERE rsrvSeq = {reservationSeq}";

                        cmd = new MySqlCommand(sql, conn);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show(selectedReservationSeqList.Count + "건의 예약을 승인 거절하였습니다.");
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
            
        }

        private void updateClassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            regClassForm regclassForm = new regClassForm();
            regclassForm.ShowDialog(); // 다른 폼 창을 불러오는 (include)
        }

        private void regClassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            regClassForm regclassForm = new regClassForm();
            regclassForm.ShowDialog(); // 다른 폼 창을 불러오는 (include)
        }

        private void selectClassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // DataGridView에 있는 기존 열들을 지움
            adminDataGrid.Columns.Clear();

            // MySQL 연결 설정
            conn = mysqlConnect();
            conn.Open();

            try
            {
                sql = string.Format("SELECT c.classSeq '강의실 일련번호', c.classCode '강의실 코드', c.className '강의실 이름', c.classFloor '강의실 층수', c.classLoca '강의실 위치', c.classMax '강의실 수용인원', c.classInfo '강의실 정보'" +
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
    }
}
