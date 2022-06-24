
namespace classroom.Management
{
    partial class FrmAcademicAdmin
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.adminid = new System.Windows.Forms.TextBox();
            this.adminname = new System.Windows.Forms.TextBox();
            this.adminsex = new System.Windows.Forms.TextBox();
            this.adminage = new System.Windows.Forms.TextBox();
            this.adminphone = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(207, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "管理员编号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(207, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "管理员姓名";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(207, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "管理员性别";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(207, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "管理员年龄";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(207, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "管理员电话";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(287, 347);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 66);
            this.button1.TabIndex = 5;
            this.button1.Text = "添加";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // adminid
            // 
            this.adminid.Location = new System.Drawing.Point(447, 75);
            this.adminid.Name = "adminid";
            this.adminid.Size = new System.Drawing.Size(142, 28);
            this.adminid.TabIndex = 6;
            // 
            // adminname
            // 
            this.adminname.Location = new System.Drawing.Point(447, 123);
            this.adminname.Name = "adminname";
            this.adminname.Size = new System.Drawing.Size(142, 28);
            this.adminname.TabIndex = 7;
            // 
            // adminsex
            // 
            this.adminsex.Location = new System.Drawing.Point(447, 167);
            this.adminsex.Name = "adminsex";
            this.adminsex.Size = new System.Drawing.Size(142, 28);
            this.adminsex.TabIndex = 8;
            // 
            // adminage
            // 
            this.adminage.Location = new System.Drawing.Point(447, 212);
            this.adminage.Name = "adminage";
            this.adminage.Size = new System.Drawing.Size(142, 28);
            this.adminage.TabIndex = 9;
            // 
            // adminphone
            // 
            this.adminphone.Location = new System.Drawing.Point(447, 263);
            this.adminphone.Name = "adminphone";
            this.adminphone.Size = new System.Drawing.Size(142, 28);
            this.adminphone.TabIndex = 10;
            // 
            // FrmAcademicAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.adminphone);
            this.Controls.Add(this.adminage);
            this.Controls.Add(this.adminsex);
            this.Controls.Add(this.adminname);
            this.Controls.Add(this.adminid);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmAcademicAdmin";
            this.Text = "添加教学楼管理员信息";
            this.Load += new System.EventHandler(this.FrmAcademicAdmin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox adminid;
        private System.Windows.Forms.TextBox adminname;
        private System.Windows.Forms.TextBox adminsex;
        private System.Windows.Forms.TextBox adminage;
        private System.Windows.Forms.TextBox adminphone;
    }
}