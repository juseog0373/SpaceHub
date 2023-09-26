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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void floor_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedFloor = floor.SelectedItem.ToString();

            try
            {
                MySqlConnection conn = mysqlConnect();
                conn.Open();

                // MySQL 쿼리 실행 - classFloor와 선택한 층을 비교하여 동일한 값을 선택합니다.
                string sql = $"SELECT * FROM classTbl WHERE classFloor = '{selectedFloor}'";
                MySqlCommand command = new MySqlCommand(sql, conn);

                // 데이터를 담을 DataTable 생성
                DataTable dataTable = new DataTable();

                // 데이터 어댑터를 사용하여 데이터를 DataTable로 가져오기
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                adapter.Fill(dataTable);

                // DataGridView에 데이터 바인딩
                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("오류 발생: " + ex.Message);
            }
        }

            private void label2_Click(object sender, EventArgs e)
        {

        }

        private void userName_TextChanged(object sender, EventArgs e)
        {

        }

        private void time1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // time1에서 선택한 값을 가져옵니다.
            string selectedTime1 = time1.SelectedItem.ToString();

            // time2 콤보 박스를 초기화하여 선택된 시간 이후의 값을 추가합니다.
            time2.Items.Clear();

            // 시간 형식을 TimeSpan으로 파싱하여 선택된 시간 이후의 시간을 계산합니다.
            TimeSpan selectedTimeSpan = TimeSpan.Parse(selectedTime1);

            // 선택된 시간 이후의 시간 옵션을 추가합니다.
            foreach (string timeOption in time1.Items)
            {
                TimeSpan timeOptionTimeSpan = TimeSpan.Parse(timeOption);
                if (timeOptionTimeSpan >= selectedTimeSpan)
                {
                    time2.Items.Add(timeOption);
                }
            }
        }

        private void time2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Calendar_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void okbtn_Click(object sender, EventArgs e)
        {

        }

        private void personnel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void purpose_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
