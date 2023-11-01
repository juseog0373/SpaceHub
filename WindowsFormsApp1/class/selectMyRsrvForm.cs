﻿using MySql.Data.MySqlClient;
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
            try
            {
                conn = mysqlConnect();
                conn.Open();

                string sql = string.Format("SELECT" +
                " r.rsrvSeq '예약번호'," +
                " u.userName '예약자명'," +
                " r.rsrvDate '예약시간'," +
                " r.rsrvGoal '예약목적'," +
                " r.rsrvPrsnl '예약인원'," +
                " r.rsrvHoursUse '이용시간'," +
                " r.rsrvYN '예약상태(승인, 대기, 거절)'" +
                " FROM reservationTbl r, userTbl u" +
                " WHERE r.userId = u.userId" +
                " AND u.userId = 2020");

                cmd = new MySqlCommand(sql, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

                DataTable table = new DataTable();
                adapter.Fill(table);

                myRsrvDataGrid.DataSource = table;

                conn.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}