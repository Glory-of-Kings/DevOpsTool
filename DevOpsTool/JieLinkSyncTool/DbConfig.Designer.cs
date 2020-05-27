namespace JieLinkSyncTool
{
    partial class DbConfig
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DbConfig));
            this.txtBoxDbPort = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBoxDb = new System.Windows.Forms.TextBox();
            this.txtBoxIp = new System.Windows.Forms.TextBox();
            this.txtBoxDbPwd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxDbUser = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnTest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBoxDbPort
            // 
            this.txtBoxDbPort.Location = new System.Drawing.Point(108, 83);
            this.txtBoxDbPort.Name = "txtBoxDbPort";
            this.txtBoxDbPort.Size = new System.Drawing.Size(120, 21);
            this.txtBoxDbPort.TabIndex = 30;
            this.txtBoxDbPort.Text = "10080";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 12);
            this.label5.TabIndex = 29;
            this.label5.Text = "数据库端口：";
            // 
            // txtBoxDb
            // 
            this.txtBoxDb.Location = new System.Drawing.Point(108, 45);
            this.txtBoxDb.Name = "txtBoxDb";
            this.txtBoxDb.ReadOnly = true;
            this.txtBoxDb.Size = new System.Drawing.Size(120, 21);
            this.txtBoxDb.TabIndex = 22;
            this.txtBoxDb.Text = "smartbox";
            // 
            // txtBoxIp
            // 
            this.txtBoxIp.Location = new System.Drawing.Point(108, 6);
            this.txtBoxIp.Name = "txtBoxIp";
            this.txtBoxIp.Size = new System.Drawing.Size(120, 21);
            this.txtBoxIp.TabIndex = 21;
            this.txtBoxIp.Text = "127.0.0.1";
            // 
            // txtBoxDbPwd
            // 
            this.txtBoxDbPwd.Location = new System.Drawing.Point(108, 169);
            this.txtBoxDbPwd.Name = "txtBoxDbPwd";
            this.txtBoxDbPwd.PasswordChar = '*';
            this.txtBoxDbPwd.Size = new System.Drawing.Size(120, 21);
            this.txtBoxDbPwd.TabIndex = 28;
            this.txtBoxDbPwd.Text = "123456";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 23;
            this.label1.Text = "盒子IP地址：";
            // 
            // txtBoxDbUser
            // 
            this.txtBoxDbUser.Location = new System.Drawing.Point(108, 126);
            this.txtBoxDbUser.Name = "txtBoxDbUser";
            this.txtBoxDbUser.Size = new System.Drawing.Size(120, 21);
            this.txtBoxDbUser.TabIndex = 27;
            this.txtBoxDbUser.Text = "test";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 24;
            this.label2.Text = "数据库名称：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 26;
            this.label4.Text = "数据库密码：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 25;
            this.label3.Text = "数据库用户：";
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(12, 209);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(218, 41);
            this.btnTest.TabIndex = 31;
            this.btnTest.Text = "测试连接";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // DbConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 260);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.txtBoxDbPort);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBoxDb);
            this.Controls.Add(this.txtBoxIp);
            this.Controls.Add(this.txtBoxDbPwd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxDbUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DbConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "数据库连接配置";
            this.Load += new System.EventHandler(this.DbConfig_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxDbPort;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBoxDb;
        private System.Windows.Forms.TextBox txtBoxIp;
        private System.Windows.Forms.TextBox txtBoxDbPwd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxDbUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnTest;
    }
}