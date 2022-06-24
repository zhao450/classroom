
namespace classroom.Management
{
    partial class FrmChangeUser
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
            this.true_password = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.new_password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // true_password
            // 
            this.true_password.Font = new System.Drawing.Font("宋体", 12F);
            this.true_password.Location = new System.Drawing.Point(323, 244);
            this.true_password.Margin = new System.Windows.Forms.Padding(4);
            this.true_password.Name = "true_password";
            this.true_password.Size = new System.Drawing.Size(271, 35);
            this.true_password.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F);
            this.label3.Location = new System.Drawing.Point(181, 255);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "确认密码：";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // new_password
            // 
            this.new_password.Font = new System.Drawing.Font("宋体", 12F);
            this.new_password.Location = new System.Drawing.Point(323, 155);
            this.new_password.Margin = new System.Windows.Forms.Padding(4);
            this.new_password.Name = "new_password";
            this.new_password.Size = new System.Drawing.Size(271, 35);
            this.new_password.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F);
            this.label2.Location = new System.Drawing.Point(181, 158);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "新的密码：";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(293, 357);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 68);
            this.button1.TabIndex = 10;
            this.button1.Text = "确认修改";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F);
            this.label1.Location = new System.Drawing.Point(181, 71);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "用户名：";
            // 
            // username
            // 
            this.username.Font = new System.Drawing.Font("宋体", 12F);
            this.username.Location = new System.Drawing.Point(323, 68);
            this.username.Margin = new System.Windows.Forms.Padding(4);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(271, 35);
            this.username.TabIndex = 13;
            // 
            // FrmChangeUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.username);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.true_password);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.new_password);
            this.Controls.Add(this.label2);
            this.Name = "FrmChangeUser";
            this.Text = "修改密码";
            this.Load += new System.EventHandler(this.FrmChangeUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox true_password;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox new_password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox username;
    }
}