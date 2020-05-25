namespace MapTable
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
            this.lbxTables = new System.Windows.Forms.ListBox();
            this.lbxMapTables = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxSource = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxPort = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxUserName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxDataName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxAddTable = new System.Windows.Forms.TextBox();
            this.btnAddTable = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btnConstrast = new System.Windows.Forms.Button();
            this.btnModifyArchiveTab = new System.Windows.Forms.Button();
            this.rtbResult = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lbxTables
            // 
            this.lbxTables.FormattingEnabled = true;
            this.lbxTables.ItemHeight = 12;
            this.lbxTables.Location = new System.Drawing.Point(26, 140);
            this.lbxTables.Name = "lbxTables";
            this.lbxTables.Size = new System.Drawing.Size(131, 184);
            this.lbxTables.TabIndex = 0;
            // 
            // lbxMapTables
            // 
            this.lbxMapTables.FormattingEnabled = true;
            this.lbxMapTables.ItemHeight = 12;
            this.lbxMapTables.Location = new System.Drawing.Point(196, 140);
            this.lbxMapTables.Name = "lbxMapTables";
            this.lbxMapTables.Size = new System.Drawing.Size(135, 184);
            this.lbxMapTables.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "服务器";
            // 
            // tbxSource
            // 
            this.tbxSource.Location = new System.Drawing.Point(71, 21);
            this.tbxSource.Name = "tbxSource";
            this.tbxSource.Size = new System.Drawing.Size(126, 21);
            this.tbxSource.TabIndex = 3;
            this.tbxSource.Text = "127.0.0.1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(233, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "端口号";
            // 
            // tbxPort
            // 
            this.tbxPort.Location = new System.Drawing.Point(289, 21);
            this.tbxPort.Name = "tbxPort";
            this.tbxPort.Size = new System.Drawing.Size(123, 21);
            this.tbxPort.TabIndex = 5;
            this.tbxPort.Text = "3306";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "用户名";
            // 
            // tbxUserName
            // 
            this.tbxUserName.Location = new System.Drawing.Point(71, 56);
            this.tbxUserName.Name = "tbxUserName";
            this.tbxUserName.Size = new System.Drawing.Size(126, 21);
            this.tbxUserName.TabIndex = 7;
            this.tbxUserName.Text = "jieLink";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(233, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "密码";
            // 
            // tbxPassword
            // 
            this.tbxPassword.Location = new System.Drawing.Point(289, 56);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.PasswordChar = '*';
            this.tbxPassword.Size = new System.Drawing.Size(123, 21);
            this.tbxPassword.TabIndex = 9;
            this.tbxPassword.Text = "js*168";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "数据库名";
            // 
            // tbxDataName
            // 
            this.tbxDataName.Location = new System.Drawing.Point(71, 89);
            this.tbxDataName.Name = "tbxDataName";
            this.tbxDataName.Size = new System.Drawing.Size(126, 21);
            this.tbxDataName.TabIndex = 11;
            this.tbxDataName.Text = "db_newg3_main";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(235, 87);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "测试连接";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(69, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 13;
            this.label6.Text = "原表";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(233, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 14;
            this.label7.Text = "对比表";
            // 
            // tbxAddTable
            // 
            this.tbxAddTable.Location = new System.Drawing.Point(26, 344);
            this.tbxAddTable.Name = "tbxAddTable";
            this.tbxAddTable.Size = new System.Drawing.Size(126, 21);
            this.tbxAddTable.TabIndex = 15;
            // 
            // btnAddTable
            // 
            this.btnAddTable.Location = new System.Drawing.Point(167, 344);
            this.btnAddTable.Name = "btnAddTable";
            this.btnAddTable.Size = new System.Drawing.Size(75, 23);
            this.btnAddTable.TabIndex = 16;
            this.btnAddTable.Text = "添加表";
            this.btnAddTable.UseVisualStyleBackColor = true;
            this.btnAddTable.Click += new System.EventHandler(this.btnAddTable_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(417, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 18;
            this.label8.Text = "结果";
            // 
            // btnConstrast
            // 
            this.btnConstrast.Location = new System.Drawing.Point(310, 344);
            this.btnConstrast.Name = "btnConstrast";
            this.btnConstrast.Size = new System.Drawing.Size(75, 23);
            this.btnConstrast.TabIndex = 19;
            this.btnConstrast.Text = "对比";
            this.btnConstrast.UseVisualStyleBackColor = true;
            this.btnConstrast.Click += new System.EventHandler(this.btnConstrast_Click);
            // 
            // btnModifyArchiveTab
            // 
            this.btnModifyArchiveTab.Location = new System.Drawing.Point(419, 344);
            this.btnModifyArchiveTab.Name = "btnModifyArchiveTab";
            this.btnModifyArchiveTab.Size = new System.Drawing.Size(75, 23);
            this.btnModifyArchiveTab.TabIndex = 20;
            this.btnModifyArchiveTab.Text = "修改归档表";
            this.btnModifyArchiveTab.UseVisualStyleBackColor = true;
            this.btnModifyArchiveTab.Click += new System.EventHandler(this.btnModifyArchiveTab_Click);
            // 
            // rtbResult
            // 
            this.rtbResult.Location = new System.Drawing.Point(361, 140);
            this.rtbResult.Name = "rtbResult";
            this.rtbResult.Size = new System.Drawing.Size(180, 184);
            this.rtbResult.TabIndex = 21;
            this.rtbResult.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 450);
            this.Controls.Add(this.rtbResult);
            this.Controls.Add(this.btnModifyArchiveTab);
            this.Controls.Add(this.btnConstrast);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnAddTable);
            this.Controls.Add(this.tbxAddTable);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbxDataName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbxPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbxUserName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxPort);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxSource);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbxMapTables);
            this.Controls.Add(this.lbxTables);
            this.Name = "Form1";
            this.Text = "字段对比工具";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxTables;
        private System.Windows.Forms.ListBox lbxMapTables;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxPort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxUserName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxDataName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbxAddTable;
        private System.Windows.Forms.Button btnAddTable;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnConstrast;
        private System.Windows.Forms.Button btnModifyArchiveTab;
        private System.Windows.Forms.RichTextBox rtbResult;
    }
}

