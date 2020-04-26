namespace WebApiTest
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
            this.btnWebClient = new System.Windows.Forms.Button();
            this.btnWebRequest = new System.Windows.Forms.Button();
            this.txtrequest = new System.Windows.Forms.TextBox();
            this.txtresponse = new System.Windows.Forms.TextBox();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbKeepAlive = new System.Windows.Forms.CheckBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnWebClient
            // 
            this.btnWebClient.Location = new System.Drawing.Point(12, 32);
            this.btnWebClient.Name = "btnWebClient";
            this.btnWebClient.Size = new System.Drawing.Size(84, 23);
            this.btnWebClient.TabIndex = 0;
            this.btnWebClient.Text = "WebClient";
            this.btnWebClient.UseVisualStyleBackColor = true;
            this.btnWebClient.Click += new System.EventHandler(this.btnWebClient_Click);
            // 
            // btnWebRequest
            // 
            this.btnWebRequest.Location = new System.Drawing.Point(12, 93);
            this.btnWebRequest.Name = "btnWebRequest";
            this.btnWebRequest.Size = new System.Drawing.Size(84, 23);
            this.btnWebRequest.TabIndex = 1;
            this.btnWebRequest.Text = "WebRequest";
            this.btnWebRequest.UseVisualStyleBackColor = true;
            this.btnWebRequest.Click += new System.EventHandler(this.btnWebRequest_Click);
            // 
            // txtrequest
            // 
            this.txtrequest.Location = new System.Drawing.Point(112, 95);
            this.txtrequest.Multiline = true;
            this.txtrequest.Name = "txtrequest";
            this.txtrequest.Size = new System.Drawing.Size(359, 84);
            this.txtrequest.TabIndex = 2;
            this.txtrequest.Text = "{\"devicesId\":159306752}";
            // 
            // txtresponse
            // 
            this.txtresponse.Location = new System.Drawing.Point(112, 219);
            this.txtresponse.Multiline = true;
            this.txtresponse.Name = "txtresponse";
            this.txtresponse.Size = new System.Drawing.Size(359, 84);
            this.txtresponse.TabIndex = 3;
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(112, 34);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(359, 21);
            this.txtUrl.TabIndex = 4;
            this.txtUrl.Text = "http://localhost:8099/api/parking/get_parking_space";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "request";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "response";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(114, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "url";
            // 
            // cbKeepAlive
            // 
            this.cbKeepAlive.AutoSize = true;
            this.cbKeepAlive.Location = new System.Drawing.Point(12, 147);
            this.cbKeepAlive.Name = "cbKeepAlive";
            this.cbKeepAlive.Size = new System.Drawing.Size(84, 16);
            this.cbKeepAlive.TabIndex = 8;
            this.cbKeepAlive.Text = "Keep Alive";
            this.cbKeepAlive.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(12, 198);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 312);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.cbKeepAlive);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.txtresponse);
            this.Controls.Add(this.txtrequest);
            this.Controls.Add(this.btnWebRequest);
            this.Controls.Add(this.btnWebClient);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Asp.Net Web Api Test";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnWebClient;
        private System.Windows.Forms.Button btnWebRequest;
        private System.Windows.Forms.TextBox txtrequest;
        private System.Windows.Forms.TextBox txtresponse;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cbKeepAlive;
        private System.Windows.Forms.Button btnClear;
    }
}

