using MySql.Data.MySqlClient;
using Org.BouncyCastle.Utilities;
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
    public partial class updateClassForm : MetroFramework.Forms.MetroForm
    {
        private adminForm adminForm;  // adminForm을 참조하기 위한 변수
        private string classSeq;

        public updateClassForm(string classSeq, adminForm adminForm)
        {
            InitializeComponent();
            this.classSeq = classSeq;
            this.adminForm = adminForm;
        }

        MySqlConnection conn = null;
        string sql = "";
        MySqlCommand cmd = new MySqlCommand();

        private void updateClassForm_Load(object sender, EventArgs e)
        {
            try
            {
                conn = mysqlConnect();
                conn.Open();

                sql = string.Format($"SELECT * FROM classTbl WHERE classSeq = {classSeq}");

                // SQL 쿼리 실행
                cmd = new MySqlCommand(sql, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    // 각 컬럼의 인덱스를 가져와서 데이터를 읽어옴
                    classCodeTxt.Text = reader.GetString("classCode");
                    classNameTxt.Text = reader.GetString("className");
                    classFloorDropDown.Text = reader.GetString("classFloor");
                    classLocaTxt.Text = reader.GetString("classLoca");
                    classMaxDropDown.Text = reader.GetString("classMax");
                    classInfoTxt.Text = reader.GetString("classInfo");
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

        private void updateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                conn = mysqlConnect();
                conn.Open();

                // 예시: 강의실 이름, 수용 인원, 층 수, 강의실 정보를 업데이트하는 쿼리
                sql = string.Format("UPDATE classTbl SET classCode = @classCode, className = @className, classMax = @classMax, classAvail=@classMax, classFloor = @classFloor, classInfo = @classInfo WHERE classSeq = @classSeq");

                // SQL 쿼리 실행
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                // 매개변수 추가
                cmd.Parameters.AddWithValue("@classCode", classCodeTxt.Text); 
                cmd.Parameters.AddWithValue("@className", classNameTxt.Text);
                cmd.Parameters.AddWithValue("@classMax", Convert.ToInt32(classMaxDropDown.Text)); 
                cmd.Parameters.AddWithValue("@classFloor", Convert.ToInt32(classFloorDropDown.Text)); 
                cmd.Parameters.AddWithValue("@classInfo", classInfoTxt.Text); 
                cmd.Parameters.AddWithValue("@classSeq", classSeq); 

                // 쿼리 실행
                int result = cmd.ExecuteNonQuery();

                // 업데이트 성공 여부 확인
                if (result > 0)
                {
                    MessageBox.Show("강의실 업데이트를 완료했습니다.");
                    adminForm.RefreshDataGridView();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("강의실 업데이트에 실패했습니다.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("업데이트 중 오류가 발생했습니다\n오류 메세지: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
