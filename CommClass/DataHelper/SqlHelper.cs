using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace CommClass.DataHelper
{
    /// <summary>
    /// SQLHelper帮助类
    /// </summary>
    public class SqlHelper
    {
        private static string dbUrl = @"Database=classroom;Data Source=127.0.0.1;User Id=root;Password=123456;pooling=false;CharSet=utf8;port=3306";
        private MySqlConnection connection;

        public MySqlConnection Connection
        {
            get
            {
                if (connection == null)
                {
                    connection = new MySqlConnection(dbUrl);
                }
                return connection;
            }
        }
        //打开数据库连接
        public void OpenConnection()
        {
            if (Connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
            else if (Connection.State == System.Data.ConnectionState.Broken)
            {
                connection.Close();
                connection.Open();
            }
        }

        //关闭数据库
        public void CloseConnection()
        {
            if (Connection.State == System.Data.ConnectionState.Open || Connection.State == System.Data.ConnectionState.Broken)
            {
                connection.Close();
            }
        }
    }
}
