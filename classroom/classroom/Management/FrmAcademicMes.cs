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
    public partial class FrmAcademicMes : DockContent
    {
        DataSet dr = new DataSet();
        private SqlHelper dbUtil = new SqlHelper();
        public FrmAcademicMes()
        {
            InitializeComponent();
        }

        private void FrmAcademicMes_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SetDataAcademic();
        }
        private void SetDataAcademic()
        {
            dr = new DataSet();
            string sql;
            sql = string.Format("SELECT  aid AS `教学楼id`,aname AS `教学楼名称`, academic.alocation AS `教学楼位置`,academic.crnum AS `教室数量`,academic.adminid AS `教学楼管理员ID` ,admin.adminname As `管理员姓名`,admin.adminsex AS `管理员性别`,admin.adminage AS `管理员年龄` ,admin.adminphone As `管理员电话` FROM academic,admin where academic.adminid=admin.adminid ");

            try
            {
                //2.执行数据库连接
                MySqlDataAdapter adapter = new MySqlDataAdapter(sql, dbUtil.Connection);
                dbUtil.OpenConnection();

                //3.开始填充表格
                adapter.Fill(dr, "sb");
                this.dataGridView1.DataSource = dr.Tables["sb"];//绑定数据源
                //下面两句话是我想让查询教学楼信息后显示更加好看一点，但是出现了点问题，先留下，等整体功能做完再解决
                //dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;// 设定包括Header和所有单元格的列宽自动调整
                //dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;// 设定包括Header和所有单元格的行高自动调整


            }
            catch (Exception)
            {
                MessageBox.Show("数据库操作错误", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
