namespace JieLinkSyncTool
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtCenterDbPwd = new System.Windows.Forms.TextBox();
            this.txtCenterDbUser = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCenterDb = new System.Windows.Forms.TextBox();
            this.txtCenterIp = new System.Windows.Forms.TextBox();
            this.rtxShowMessage = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCenterDbPort = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnTestConn = new System.Windows.Forms.Button();
            this.btnStartTask = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtCmd = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCheckRow = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCheckDay = new System.Windows.Forms.TextBox();
            this.txtLoopSecond = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnExit = new System.Windows.Forms.ToolStripMenuItem();
            this.chbVersion = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCenterDbPwd
            // 
            this.txtCenterDbPwd.Location = new System.Drawing.Point(99, 185);
            this.txtCenterDbPwd.Name = "txtCenterDbPwd";
            this.txtCenterDbPwd.PasswordChar = '*';
            this.txtCenterDbPwd.Size = new System.Drawing.Size(120, 21);
            this.txtCenterDbPwd.TabIndex = 15;
            this.txtCenterDbPwd.Text = "123456";
            // 
            // txtCenterDbUser
            // 
            this.txtCenterDbUser.Location = new System.Drawing.Point(99, 142);
            this.txtCenterDbUser.Name = "txtCenterDbUser";
            this.txtCenterDbUser.Size = new System.Drawing.Size(120, 21);
            this.txtCenterDbUser.TabIndex = 14;
            this.txtCenterDbUser.Text = "test";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 13;
            this.label4.Text = "数据库密码：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 12;
            this.label3.Text = "数据库用户：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 11;
            this.label2.Text = "数据库名称：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 10;
            this.label1.Text = "中心IP地址：";
            // 
            // txtCenterDb
            // 
            this.txtCenterDb.Location = new System.Drawing.Point(99, 61);
            this.txtCenterDb.Name = "txtCenterDb";
            this.txtCenterDb.ReadOnly = true;
            this.txtCenterDb.Size = new System.Drawing.Size(120, 21);
            this.txtCenterDb.TabIndex = 9;
            this.txtCenterDb.Text = "db_newg3_main";
            // 
            // txtCenterIp
            // 
            this.txtCenterIp.Location = new System.Drawing.Point(99, 22);
            this.txtCenterIp.Name = "txtCenterIp";
            this.txtCenterIp.Size = new System.Drawing.Size(120, 21);
            this.txtCenterIp.TabIndex = 8;
            this.txtCenterIp.Text = "127.0.0.1";
            // 
            // rtxShowMessage
            // 
            this.rtxShowMessage.Location = new System.Drawing.Point(267, 12);
            this.rtxShowMessage.Name = "rtxShowMessage";
            this.rtxShowMessage.Size = new System.Drawing.Size(439, 558);
            this.rtxShowMessage.TabIndex = 16;
            this.rtxShowMessage.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCenterDbPort);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtCenterDb);
            this.groupBox1.Controls.Add(this.btnTestConn);
            this.groupBox1.Controls.Add(this.txtCenterIp);
            this.groupBox1.Controls.Add(this.txtCenterDbPwd);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtCenterDbUser);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(235, 274);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "中心数据库连接";
            // 
            // txtCenterDbPort
            // 
            this.txtCenterDbPort.Location = new System.Drawing.Point(99, 99);
            this.txtCenterDbPort.Name = "txtCenterDbPort";
            this.txtCenterDbPort.Size = new System.Drawing.Size(120, 21);
            this.txtCenterDbPort.TabIndex = 20;
            this.txtCenterDbPort.Text = "3306";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 12);
            this.label5.TabIndex = 19;
            this.label5.Text = "数据库端口：";
            // 
            // btnTestConn
            // 
            this.btnTestConn.Location = new System.Drawing.Point(6, 222);
            this.btnTestConn.Name = "btnTestConn";
            this.btnTestConn.Size = new System.Drawing.Size(223, 42);
            this.btnTestConn.TabIndex = 18;
            this.btnTestConn.Text = "测试连接";
            this.btnTestConn.UseVisualStyleBackColor = true;
            this.btnTestConn.Click += new System.EventHandler(this.btnTestConn_Click);
            // 
            // btnStartTask
            // 
            this.btnStartTask.Enabled = false;
            this.btnStartTask.Location = new System.Drawing.Point(8, 230);
            this.btnStartTask.Name = "btnStartTask";
            this.btnStartTask.Size = new System.Drawing.Size(222, 42);
            this.btnStartTask.TabIndex = 19;
            this.btnStartTask.Text = "开启检测";
            this.btnStartTask.UseVisualStyleBackColor = true;
            this.btnStartTask.Click += new System.EventHandler(this.btnStartTask_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chbVersion);
            this.groupBox2.Controls.Add(this.txtCmd);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtCheckRow);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtCheckDay);
            this.groupBox2.Controls.Add(this.txtLoopSecond);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.btnStartTask);
            this.groupBox2.Location = new System.Drawing.Point(13, 292);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(234, 278);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "任务配置";
            // 
            // txtCmd
            // 
            this.txtCmd.Location = new System.Drawing.Point(98, 146);
            this.txtCmd.Multiline = true;
            this.txtCmd.Name = "txtCmd";
            this.txtCmd.Size = new System.Drawing.Size(120, 74);
            this.txtCmd.TabIndex = 32;
            this.txtCmd.Text = "82A";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 146);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 31;
            this.label9.Text = "命令字：";
            // 
            // txtCheckRow
            // 
            this.txtCheckRow.Location = new System.Drawing.Point(98, 108);
            this.txtCheckRow.Name = "txtCheckRow";
            this.txtCheckRow.Size = new System.Drawing.Size(120, 21);
            this.txtCheckRow.TabIndex = 30;
            this.txtCheckRow.Text = "100";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 29;
            this.label6.Text = "检测条数：";
            // 
            // txtCheckDay
            // 
            this.txtCheckDay.Location = new System.Drawing.Point(98, 69);
            this.txtCheckDay.Name = "txtCheckDay";
            this.txtCheckDay.Size = new System.Drawing.Size(120, 21);
            this.txtCheckDay.TabIndex = 22;
            this.txtCheckDay.Text = "1";
            // 
            // txtLoopSecond
            // 
            this.txtLoopSecond.Location = new System.Drawing.Point(98, 31);
            this.txtLoopSecond.Name = "txtLoopSecond";
            this.txtLoopSecond.Size = new System.Drawing.Size(120, 21);
            this.txtLoopSecond.TabIndex = 21;
            this.txtLoopSecond.Text = "5";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 12);
            this.label7.TabIndex = 23;
            this.label7.Text = "频率：（秒）";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 24;
            this.label8.Text = "检测天数：";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipTitle = "提示";
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "JieLink数据同步工具";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnExit});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(101, 26);
            // 
            // btnExit
            // 
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 22);
            this.btnExit.Text = "退出";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // chbVersion
            // 
            this.chbVersion.AutoSize = true;
            this.chbVersion.Location = new System.Drawing.Point(17, 185);
            this.chbVersion.Name = "chbVersion";
            this.chbVersion.Size = new System.Drawing.Size(66, 16);
            this.chbVersion.TabIndex = 33;
            this.chbVersion.Text = "2.0以下";
            this.chbVersion.UseVisualStyleBackColor = true;
            this.chbVersion.CheckedChanged += new System.EventHandler(this.chbVersion_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 578);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rtxShowMessage);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JieLink数据同步工具";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtCenterDbPwd;
        private System.Windows.Forms.TextBox txtCenterDbUser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCenterDb;
        private System.Windows.Forms.TextBox txtCenterIp;
        private System.Windows.Forms.RichTextBox rtxShowMessage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCenterDbPort;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnTestConn;
        private System.Windows.Forms.Button btnStartTask;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtCheckRow;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCheckDay;
        private System.Windows.Forms.TextBox txtLoopSecond;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCmd;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnExit;
        private System.Windows.Forms.CheckBox chbVersion;
    }
}

