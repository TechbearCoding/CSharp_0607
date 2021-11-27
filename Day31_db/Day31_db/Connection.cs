using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day31_db
{
    class Connection
    {
        private MySqlConnection conn;
        public void Open()
        {
            var settings = new MySqlConnectionStringBuilder
            {
                Server = "178.128.47.243",
                UserID = "root",
                Password = "danger123",
                Port = 3306,
                Database = "Books"
            };

            conn = new MySqlConnection(settings.ConnectionString);
            conn.Open();

        }

        public void Close()
        {
            conn.Close();
        }

        public MySqlConnection GetConnetion()
        {
            return conn;
        }
    }
}
