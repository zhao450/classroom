using classroomBLL.BussinessLogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using CommClass.DataHelper;
using classroom.CommHelper;
using classroomModels.Models;

namespace classroom
{
    public partial class FrmLogin : Form
    {
        User user = new User();
        private SqlHelper dbUtil = new SqlHelper();
        /// <summary>
        /// 用户业务逻辑变量
        /// </summary>
        private readonly ManageBLL managerBLL = new ManageBLL();
        /// <summary>
        /// 构造函数
        /// </summary>
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 退出系统
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// 点击登录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void start_Click(object sender, EventArgs e)
        {

            try
            {
                //1.创建sql语句

                string sql = string.Format("select * from people where username='{0}' and  password='{1}'", login.Text.Trim(), pass.Text.Trim());
                //2.执行数据库连接
                MySqlCommand cmd = new MySqlCommand(sql, dbUtil.Connection);

                //3.打开数据库
                dbUtil.OpenConnection();
                //4.开始查询
                MySqlDataReader reader = cmd.ExecuteReader();

                //5.开始验证
                if (reader.Read())
                {
                    //目前不知道怎么写（UseInfo目前也用不上）
                    //想在窗口下显示用户名
                    //UseInfo.CurrentUserName = ;
                    DialogResult = DialogResult.OK;
                    user.Username = reader[1].ToString();
                    user.Password = reader[2].ToString();
                    FrmLogin frmLogin = new FrmLogin();
                    frmLogin.user = user;
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("用户名或密码不存在", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("数据库操作错误", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                dbUtil.CloseConnection();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}

