using CommClass.DataHelper;
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
using WeifenLuo.WinFormsUI.Docking;

namespace classroom.Management
{
    public partial class FrmAddUser : DockContent
    {
        private SqlHelper dbUtil = new SqlHelper();
        private void SetNull()
        {
            username.Text = "";
            password.Text = "";
            adapter.Text = "";
            name1.Text = "";
        }
        public FrmAddUser()
        {
            InitializeComponent();
        }


        private void FrmAddUser_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }





        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                //1.创建sql语句

                string sql = string.Format("insert into people values('{0}','{1}','{2}','{3}')", username.Text.Trim(), password.Text.Trim(), adapter.Text.Trim(), name.Text.Trim());
                //2.执行数据库连接
                MySqlCommand cmd = new MySqlCommand(sql, dbUtil.Connection);

                //3.打开数据库
                dbUtil.OpenConnection();
                //4.开始查询
                int result = cmd.ExecuteNonQuery();

                //5.开始验证
                if (result == 1)
                {
                    MessageBox.Show("添加成功", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.SetNull();

                }
                else
                {
                    MessageBox.Show("添加失败", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void button2_Click_1(object sender, EventArgs e)
        {
            SetNull();
        }
    }
}
