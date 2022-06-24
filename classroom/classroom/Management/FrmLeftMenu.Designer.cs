
namespace classroom.Management
{
    partial class FrmLeftMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLeftMenu));
            this.PlMenu = new System.Windows.Forms.Panel();
            this.imgList = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // PlMenu
            // 
            this.PlMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PlMenu.Location = new System.Drawing.Point(0, 0);
            this.PlMenu.Name = "PlMenu";
            this.PlMenu.Size = new System.Drawing.Size(800, 1141);
            this.PlMenu.TabIndex = 0;
            this.PlMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.PlMenu_Paint);
            // 
            // imgList
            // 
            this.imgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgList.ImageStream")));
            this.imgList.TransparentColor = System.Drawing.Color.Transparent;
            this.imgList.Images.SetKeyName(0, "employee_man.png");
            this.imgList.Images.SetKeyName(1, "add.png");
            this.imgList.Images.SetKeyName(2, "base.png");
            this.imgList.Images.SetKeyName(3, "delete.png");
            this.imgList.Images.SetKeyName(4, "Geo_16.png");
            this.imgList.Images.SetKeyName(5, "help_16.png");
            this.imgList.Images.SetKeyName(6, "login.png");
            this.imgList.Images.SetKeyName(7, "menu_16.png");
            this.imgList.Images.SetKeyName(8, "modify.png");
            this.imgList.Images.SetKeyName(9, "password.png");
            this.imgList.Images.SetKeyName(10, "pingjia.png");
            this.imgList.Images.SetKeyName(11, "preferencest.png");
            this.imgList.Images.SetKeyName(12, "reset.png");
            this.imgList.Images.SetKeyName(13, "rizhi.png");
            this.imgList.Images.SetKeyName(14, "science.png");
            this.imgList.Images.SetKeyName(15, "search.png");
            this.imgList.Images.SetKeyName(16, "userName.png");
            // 
            // FrmLeftMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 1141);
            this.Controls.Add(this.PlMenu);
            this.Name = "FrmLeftMenu";
            this.Text = "菜单导航";
            this.Load += new System.EventHandler(this.FrmLeftMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PlMenu;
        private System.Windows.Forms.ImageList imgList;
    }
}