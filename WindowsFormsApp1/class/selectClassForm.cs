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
using static dbConnectSpace.dbConnection; //dbConnection 임포트

namespace WindowsFormsApp1
{
    public partial class selectClassForm : Form
    {
        public selectClassForm()
        {
            InitializeComponent();
        }

        private void selectClassBtn_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection conn = mysqlConnect();
                conn.Open();

                string classSearch = classNameDropDown.Text;
                Console.WriteLine("classSearch : " + classSearch);

                string[] classSearchs = classSearch.Split(' ');

                string classLoca = classSearchs[0].Trim();
                string classFloor = classSearchs[1].Substring(0, 1);


                Console.WriteLine($"classLoca : {classLoca}");
                Console.WriteLine($"classFloor : {classFloor}");

                string sql = string.Format("SELECT classCode as '강의실 코드', className as '강의실 이름', classFloor as '강의실 층수', classLoca '강의실 위치' FROM classTbl WHERE classLoca = '{0}' AND classFloor = '{1}'", classLoca, classFloor);

                MySqlCommand cmd = new MySqlCommand(sql, conn);
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
            string[] startHoursArr = startHoursDropDown.Text.Split(':');
            string[] endHoursArr = endHoursDropDown.Text.Split(':');

            int startHours = Int32.Parse(startHoursArr[0].Trim());
            int endHours = Int32.Parse(endHoursArr[0].Trim());

            Console.WriteLine($"startHours : {startHours}");
            Console.WriteLine($"endHours : {endHours}");

            if (endHours < startHours)
            {
                MessageBox.Show("예약 시간을 다시 확인해주세요");
            }
        }

        private void selectClassForm_Load(object sender, EventArgs e)
        {

        }
    }
}
