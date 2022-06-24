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
    public partial class FrmChangeUser : DockContent
    {
        private SqlHelper dbUtil = new SqlHelper();
        public FrmChangeUser()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (CheckInput())
            {
                UpdatePassWord();
            }
            
        }
        private bool CheckInput()
        {
            if (username.Text.Trim().Length == 0)
            {
                MessageBox.Show("用户名不能为空。", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (new_password.Text.Trim().Length == 0)
            {
                MessageBox.Show("新密码不能为空。", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (true_password.Text.Trim().Length == 0)
            {
                MessageBox.Show("请再次输入密码。", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (true_password.Text.Trim() != new_password.Text.Trim())
            {
                MessageBox.Show("两次密码输入不一致。", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        private void FrmChangeUser_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
           

        }
        private void UpdatePassWord()
        {
            try
            {
                //1.创建sql语句
                string sql = string.Format(@" update people set password='{0}' where username='{1}'", new_password.Text.Trim(), username.Text.Trim());
                //2.执行数据库连接
                MySqlCommand cmd = new MySqlCommand(sql, dbUtil.Connection);
                //3.打开数据库
                dbUtil.OpenConnection();
                //4.开始更改
                int result = cmd.ExecuteNonQuery();
                //5.给出用户提示
                if (result == 1)
                {
                    MessageBox.Show("修改成功。", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("修改失败。", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("数据库操作错误。", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                dbUtil.CloseConnection();
            }
        }

        
    }
}
