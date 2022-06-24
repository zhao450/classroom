using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UtilityLibrary.WinControls;
using WeifenLuo.WinFormsUI.Docking;
using MySql.Data.MySqlClient;

namespace classroom.Management
{
    public partial class FrmLeftMenu : DockContent
    {
        /// <summary>
        /// “OutLookBar”工具条
        /// </summary>

        private OutlookBar outlookBar = new OutlookBar();
        /// <summary>
        /// 构造函数
        /// </summary>

        public FrmLeftMenu()
        {
            InitializeComponent();
            InitiOutlookBar();
        }
        /// <summary>
        /// 初始化菜单导航
        /// </summary>
        private void InitiOutlookBar()
        {
            OutlookBarBand sysSetBarBand = new OutlookBarBand("系统设置");
            sysSetBarBand.SmallImageList = imgList;
            sysSetBarBand.LargeImageList = imgList;


            OutlookBarItem addUser = default;

            addUser = new OutlookBarItem("添加用户", 16);
            addUser.Tag = "FrmAddUser";
            sysSetBarBand.Items.Add(addUser);

            addUser = new OutlookBarItem("查询用户", 1);
            addUser.Tag = "FrmUserList";
            sysSetBarBand.Items.Add(addUser);

            addUser = new OutlookBarItem("修改密码", 12);
            addUser.Tag = "FrmChangeUser";
            sysSetBarBand.Items.Add(addUser);

            addUser = new OutlookBarItem("退出系统", 3);
            addUser.Tag = "FrmLogin";
            sysSetBarBand.Items.Add(addUser);


            sysSetBarBand.Background = SystemColors.AppWorkspace;
            sysSetBarBand.TextColor = Color.White;
            outlookBar.Bands.Add(sysSetBarBand);
            //教学楼管理
            OutlookBarBand HouseClassRoomManage = new OutlookBarBand("教学楼管理");
            HouseClassRoomManage.SmallImageList = imgList;
            HouseClassRoomManage.LargeImageList = imgList;

            OutlookBarItem addacademic = default;

            addacademic = new OutlookBarItem("教学楼信息", 13);
            addacademic.Tag = "FrmAcademicMes";
            HouseClassRoomManage.Items.Add(addacademic);

            addacademic = new OutlookBarItem("添加教学楼管理员", 16);
            addacademic.Tag = "FrmAcademicAdmin";
            HouseClassRoomManage.Items.Add(addacademic);
            HouseClassRoomManage.Background = SystemColors.AppWorkspace;
            HouseClassRoomManage.TextColor = Color.White;
            outlookBar.Bands.Add(HouseClassRoomManage);
            //教室管理
            OutlookBarBand ClassRoomManage = new OutlookBarBand("教室管理");
            ClassRoomManage.SmallImageList = imgList;
            ClassRoomManage.LargeImageList = imgList;

            OutlookBarItem addClassRoomList = default;

            addClassRoomList = new OutlookBarItem("教室列表", 13);
            addClassRoomList.Tag = "FrmClassRList";
            ClassRoomManage.Items.Add(addClassRoomList);

            addClassRoomList = new OutlookBarItem("添加教室", 1);
            addClassRoomList.Tag = "FrmClassRoomIndex";
            ClassRoomManage.Items.Add(addClassRoomList);
            ClassRoomManage.Background = SystemColors.AppWorkspace;
            ClassRoomManage.TextColor = Color.White;
            outlookBar.Bands.Add(ClassRoomManage);



            //自习教室管理
            OutlookBarBand SelfClassRoomManage = new OutlookBarBand("自习教室管理");
            SelfClassRoomManage.SmallImageList = imgList;
            SelfClassRoomManage.LargeImageList = imgList;
            OutlookBarItem addzixiRoom = default;

            addzixiRoom = new OutlookBarItem("自习教室列表", 13);
            addzixiRoom.Tag = "FrmClassRList";
            SelfClassRoomManage.Items.Add(addzixiRoom);

            addzixiRoom = new OutlookBarItem("添加自习教室", 1);
            addzixiRoom.Tag = "FrmAddZiXiRoom";
            SelfClassRoomManage.Items.Add(addzixiRoom);
            SelfClassRoomManage.Background = SystemColors.AppWorkspace;
            SelfClassRoomManage.TextColor = Color.White;
            outlookBar.Bands.Add(SelfClassRoomManage);


            //临时借用教室管理
            OutlookBarBand TemClassRoomManage = new OutlookBarBand("临时借用教室管理");
            TemClassRoomManage.SmallImageList = imgList;
            TemClassRoomManage.LargeImageList = imgList;


            OutlookBarItem addTemRoom = default;

            addTemRoom = new OutlookBarItem("临时借用教室列表", 13);
            addTemRoom.Tag = "FrmClassRList";
            TemClassRoomManage.Items.Add(addTemRoom);

            addTemRoom = new OutlookBarItem("添加临时借用教室", 1);
            addTemRoom.Tag = "FrmAddTemRoom";
            TemClassRoomManage.Items.Add(addTemRoom);
            TemClassRoomManage.Background = SystemColors.AppWorkspace;
            TemClassRoomManage.TextColor = Color.White;
            outlookBar.Bands.Add(TemClassRoomManage);
            //考试教室管理
            OutlookBarBand TestClassRoomManage = new OutlookBarBand("考试教室管理");
            TestClassRoomManage.SmallImageList = imgList;
            TestClassRoomManage.LargeImageList = imgList;


            OutlookBarItem addTestRoom = default;

            addTestRoom = new OutlookBarItem("考试教室列表", 13);
            addTestRoom.Tag = "FrmClassRList";
            TestClassRoomManage.Items.Add(addTestRoom);

            addTestRoom = new OutlookBarItem("添加考试教室", 1);
            addTestRoom.Tag = "FrmAddTestRoom";
            TestClassRoomManage.Items.Add(addTestRoom);
            TestClassRoomManage.Background = SystemColors.AppWorkspace;
            TestClassRoomManage.TextColor = Color.White;
            outlookBar.Bands.Add(TestClassRoomManage);
            outlookBar.Dock = DockStyle.Fill;
            outlookBar.SetCurrentBand(0);
            outlookBar.ItemClicked += OutlookBar_ItemClicked;
            PlMenu.Controls.AddRange(new Control[] { outlookBar });

        }

        private void OutlookBar_ItemClicked(OutlookBarBand band, OutlookBarItem item)
        {
            string formName = item.Tag as string;
            FrmMain frmMain = this.Parent.Parent.Parent.Parent as FrmMain;
            switch (formName)
            {
                case "FrmAddUser":
                    // MessageBox.Show("");
                    FrmAddUser frmAddUser = new FrmAddUser();
                    frmAddUser.Show(frmMain.WfdockPanel);
                    break;
                case "FrmUserList":
                    // MessageBox.Show("");
                    FrmUserList frmUserList = new FrmUserList();
                    frmUserList.Show(frmMain.WfdockPanel);
                    break;
                case "FrmChangeUser":
                    // MessageBox.Show("");
                    FrmChangeUser frmChangeUser = new FrmChangeUser();
                    frmChangeUser.Show(frmMain.WfdockPanel);
                    break;
                case "FrmLogin":
                    Application.Exit();
                    //this.Dispose();
                    //FrmLogin frmLogin = new FrmLogin();
                    //frmLogin.Show(frmMain.WfdockPanel);
                    break;
                case "FrmAcademicMes":
                    // MessageBox.Show("");
                    FrmAcademicMes frmAcademicMes = new FrmAcademicMes();
                    frmAcademicMes.Show(frmMain.WfdockPanel);
                    break;
                case "FrmAcademicAdmin":
                    // MessageBox.Show("");
                    FrmAcademicAdmin frmAcademicAdmin = new FrmAcademicAdmin();
                    frmAcademicAdmin.Show(frmMain.WfdockPanel);
                    break;
                case "FrmClassRList":
                    // MessageBox.Show("");
                    FrmClassRList frmClassRList = new FrmClassRList();
                    frmClassRList.Show(frmMain.WfdockPanel);
                    break;
                case "FrmClassRoomIndex":
                    // MessageBox.Show("");
                    FrmClassRoomIndex frmClassRoomIndex = new FrmClassRoomIndex();
                    frmClassRoomIndex.Show(frmMain.WfdockPanel);
                    break;
                case "FrmAddZiXiRoom":
                    // MessageBox.Show("");
                    FrmAddZiXiRoom frmAddZiXiRoom = new FrmAddZiXiRoom();
                    frmAddZiXiRoom.Show(frmMain.WfdockPanel);
                    break;
                case "FrmAddTemRoom":
                    // MessageBox.Show("");
                    FrmAddTemRoom frmAddTemRoom = new FrmAddTemRoom();
                    frmAddTemRoom.Show(frmMain.WfdockPanel);
                    break;
                case "FrmAddTestRoom":
                    // MessageBox.Show("");
                    FrmAddTestRoom frmAddTestRoom = new FrmAddTestRoom();
                    frmAddTestRoom.Show(frmMain.WfdockPanel);
                    break;
                default:
                    break;
            }
        }

        private void FrmLeftMenu_Load(object sender, EventArgs e)
        {

        }

        private void PlMenu_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
