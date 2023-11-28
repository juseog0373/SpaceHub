using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dbConnectSpace
{
    internal class dbConnection
    {

        public dbConnection() {
        }

        public static MySqlConnection mysqlConnect()
        {
            MySqlConnection conn = new MySqlConnection("Server=localhost;Port=3306;Database=spacehub;Uid=root;Pwd=abcd1234;");
            return conn;
        }
    }
}
