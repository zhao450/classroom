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
    public partial class FrmUserList : DockContent
    {
        DataSet dr = new DataSet();
        private SqlHelper dbUtil = new SqlHelper();
        public FrmUserList()
        {
            InitializeComponent();
        }

        private void FrmUserList_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            SetDataUser();
        }
        private void SetDataUser()
        {
            dr = new DataSet();
            string sql;
            if (username.Text.Trim() == null)
            {
                 sql = string.Format("select username as '用户名', adapter as '职称', name as '姓名'from people  ");
            }
            else
            {
                 sql = string.Format("select username as '用户名', adapter as '职称', name as '姓名'from people where username like '%{0}%' ", username.Text.Trim());
            }
           
            try
            {
                //2.执行数据库连接
                MySqlDataAdapter adapter = new MySqlDataAdapter(sql, dbUtil.Connection);
                dbUtil.OpenConnection();

                //3.开始填充表格
                adapter.Fill(dr, "sb");
                this.dataGridView1.DataSource=dr.Tables["sb"];//绑定数据源

            }
            catch (Exception)
            {
                MessageBox.Show("数据库操作错误", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

       

        private void username_Click(object sender, EventArgs e)
        {

        }
    }
}
