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

namespace JieLinkSyncTool
{
    public partial class DbConfig : Form
    {
        public DbConfig(string Ip)
        {
            InitializeComponent();
            this.Ip = Ip;
        }

        public string Ip { get; set; }

        public string DbConnString { get; private set; }

        private void btnTest_Click(object sender, EventArgs e)
        {
            string boxConn = $"Data Source={Ip};port={txtBoxDbPort.Text};User ID={txtBoxDbUser.Text};Password={txtBoxDbPwd.Text};Initial Catalog=smartbox;";

            try
            {
                string cmd = "select * from sys_boxinformation";
                MySqlHelper.ExecuteDataset(boxConn, cmd);
                DbConnString = boxConn;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("连接错误，请重新输入");
            }
        }

        private void DbConfig_Load(object sender, EventArgs e)
        {
            this.txtBoxIp.Text = Ip;
        }
    }
}
