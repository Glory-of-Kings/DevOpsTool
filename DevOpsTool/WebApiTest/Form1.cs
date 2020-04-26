using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebApiTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnWebClient_Click(object sender, EventArgs e)
        {
            string url = txtUrl.Text.Trim();
            string param = txtrequest.Text.Trim();
            string rquest = "";
            if (param.IsNullOrEmpty())
            {
                rquest = url;
            }
            else
            {
                rquest = url + "?param=" + param;
            }
            string result = WebClientHelper.DownloadString(rquest);
            txtresponse.Text = result;
        }

        private void btnWebRequest_Click(object sender, EventArgs e)
        {
            string url = txtUrl.Text.Trim();
            string param = txtrequest.Text.Trim();
            string rquest = "";
            if (param.IsNullOrEmpty())
            {
                rquest = url;
            }
            else
            {
                rquest = url + "?param=" + param;
            }
            WebRequestHelper.KeepAlive = cbKeepAlive.Checked;
            string result = WebRequestHelper.HttpGet(rquest, "");
            txtresponse.Text = result;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtresponse.Text = "";
        }
    }
}
