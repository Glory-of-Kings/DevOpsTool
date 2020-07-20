using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CreateInsertSqlForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strConn = ExcelConnectionString(this.tbxPath.Text.ToString());
            DataSet ds = new DataSet();
            OleDbDataAdapter oada = new OleDbDataAdapter("select * from [Sheet1$]", strConn);
            oada.Fill(ds);
            DataTable dt = ds.Tables[0];
            string sql = "";
            string sqlTemp = ReadFileText("模板sql.txt");
            foreach (DataRow dr in dt.Rows)
            {
                //int index = dr.ItemArray.Length;
                sql += string.Format(sqlTemp, dr.ItemArray) + "\n";
            }
            WriteFileText(sql);
            MessageBox.Show("脚本已写入程序目录sql.txt文件中");
        }

        public static string ExcelConnectionString(string filePhysicalPath)
        {
            string connectionString = string.Empty;
            string fileExtension = filePhysicalPath.Substring(filePhysicalPath.LastIndexOf(".") + 1);
            switch (fileExtension)
            {
                case "xls":
                    connectionString = String.Format("Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties=\"Excel 8.0;HDR=YES;IMEX=1\"", filePhysicalPath);
                    break;
                case "xlsx":
                    connectionString = String.Format("Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties=\"Excel 8.0;HDR=YES\"", filePhysicalPath);
                    break;
            }
            return connectionString;
        }

        public string ReadFileText(string fileName)
        {
            string filePath = System.IO.Directory.GetCurrentDirectory() + "\\" + fileName;
            string text = "";
            try
            {
                if (File.Exists(filePath))
                {
                    text = File.ReadAllText(filePath);
                    byte[] mybyte = Encoding.UTF8.GetBytes(text);
                    text = Encoding.UTF8.GetString(mybyte);
                    return text;
                }
                else
                {
                    MessageBox.Show("文件不存在");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return text;
        }

        public void WriteFileText(string text)
        {
            //文件路径
            string filePath = System.IO.Directory.GetCurrentDirectory() + "\\sql.txt";
            try
            {
                //检测文件夹是否存在，不存在则创建
                //string mystr1 = NiceFileProduce.CheckAndCreatPath(NiceFileProduce.DecomposePathAndName(filePath, NiceFileProduce.DecomposePathEnum.PathOnly));

                using (StreamWriter sw = new StreamWriter(filePath, false, Encoding.UTF8))
                {
                    byte[] mybyte = Encoding.UTF8.GetBytes(text);
                    text = Encoding.UTF8.GetString(mybyte);
                    sw.Write(text);
                    // MessageBox.Show("写入数据："+write);
                }

            }
            catch
            {

            }
        }
    }
}
