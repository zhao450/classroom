
using classroomIDAL.Interface;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classroomDAL.DataAccessLayer
{
    public class ManageDAL : lManageDAL
    {
        /// <summary>
        /// 检测用户登录
        /// </summary>
        /// <param name="userNamme"></param>
        /// <param name="userPass"></param>
        /// <returns></returns>
        public bool CheckUserLogin(string userName, string userPass)
        {
            return true;

            string dbUrl = @"Database=classroom;Data Source=127.0.0.1;User Id=root;Password=123456;pooling=false;CharSet=utf8;port=3306";
            MySqlConnection connection;
            if (connection == null)
            {
                connection = new MySqlConnection(dbUrl);
            }
            connection.Open();
            string sql = "select * from people where username=@uasername and password=@password";
            MySqlCommand cmd = new MySqlCommand(sql);
            connection.Close();

        }
    }
}

