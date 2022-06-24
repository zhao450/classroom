using classroomModels.Models;
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
    public partial class FrmMain : Form
    {
        User user = new User();
        public FrmMain()
        {
            InitializeComponent();
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }

        private void WfdockPanel_Paint(object sender, PaintEventArgs e)
        {

        }
        /// <summary>
        /// 床窗体加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMain_Load(object sender, EventArgs e)
        {
            LoadLeftAndRight();
        }

        private void LoadLeftAndRight()
        {
            WfdockPanel.Theme = new VS2013BlueTheme();//设置主题
            FrmLeftMenu frmLeftMenu = new FrmLeftMenu();
            frmLeftMenu.Show(WfdockPanel, DockState.DockLeft);//加载左侧导航菜单
            WfdockPanel.DockLeftPortion = 200;//设置左侧导航菜单默认宽度
            FrmRightMain frmRightMain = new FrmRightMain();
            frmRightMain.Show(WfdockPanel);
            toolStripStatusLabel1.Text = "登陆时间：" + DateTime.Now.ToString().Replace("/", "-");
            toolStripStatusLabel2.Text = "今天日期：" + DateTime.Now.ToLongDateString();
            toolStripStatusLabel3.Text = "你好：" + user.Username + "用户";
        }
        /// <summary>
        /// 重置工作区
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TsmiResetWorkArea_Click(object sender, EventArgs e)
        {
            LoadLeftAndRight();
        }
        /// <summary>
        /// 关闭所有打开文档
        /// </summary>
        private void CloseWflDocuments()
        {
            DockContentCollection dockContents = WfdockPanel.Contents;
            int i = 0;
            while (i < dockContents.Count)
            {
                DockState dockState = dockContents[i].DockHandler.DockState;
                if (dockState == DockState.Document || dockState == DockState.DockLeft)
                {
                    dockContents[i].DockHandler.Close();
                }
                else
                {
                    i++;
                }
            }
        }

        private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void WfdockPanel_ActiveContentChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 添加用户
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TsmiAddUser_Click(object sender, EventArgs e)
        {

        }

    }
}
