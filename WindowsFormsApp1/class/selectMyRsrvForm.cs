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

namespace WindowsFormsApp1
{
    public partial class selectMyRsrvForm : Form
    {
        public selectMyRsrvForm()
        {
            InitializeComponent();
        }

        private DataGridViewRow selectedClassRow;

        MySqlCommand cmd = null;
        MySqlConnection conn = null;
        
        private void selectMyRsrvForm_Load(object sender, EventArgs e)
        {
            // 예약조회 폼 로드시 예약정보 조회 후 출력
            try
            {
                conn = mysqlConnect();
                conn.Open();

                string sql = string.Format("SELECT" +
                " r.rsrvSeq '예약번호'," +
                " u.userName '예약자명'," +
                " r.rsrvDate '예약일자'," +
                " r.rsrvGoal '예약목적'," +
                " r.rsrvPrsnl '예약인원'," +
                " r.rsrvHoursUse '이용시간'," +
                " CASE WHEN rsrvYN = 'Y' THEN '승인 완료'"+
                " WHEN rsrvYN = 'N' THEN '승인 대기'"+
                " END AS '예약 상태'" +
                " FROM reservationTbl r, userTbl u" +
                " WHERE r.userId = u.userId" +
                " AND u.userId = {0}"+
                " ORDER BY rsrvSeq DESC", User.UserId);

                cmd = new MySqlCommand(sql, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

                DataTable table = new DataTable();
                adapter.Fill(table);

                myRsrvDataGrid.DataSource = table;

                conn.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); //데이터 조회 실패시 오류 메세지 화면 출력
            }
        }
    }
}
