using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PrintTest;
using System.Management;

namespace PrintTest
{
    public partial class Form1 : Form
    {
        //TicketPrinterHelper m_printHelper;
        TicketPrinterHelper m_printHelper = new TicketPrinterHelper();
        
        //字体名
        public static string FontName = null;

        public static string m_ImagePath;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
                FontName = textBox1.Text;


            m_printHelper.CompanyName = "打印测试";
            m_printHelper.DrTtile.Clear();
            m_printHelper.DrTtile.Add("车辆出场收费小票");
            m_printHelper.DrContent.Clear();
            m_printHelper.DrContent.Add("0123456789", "0123456789");
            m_printHelper.DrContent.Add("汉字测试汉字测试麤龘 ", "汉字测试汉字测试麤龘");
            m_printHelper.DrContent.Add("全角测试ＡＢＣａｂｃ。，。", "全角测试１２３");
            
            m_printHelper.PrintTicket();

            //显示打印机配置
            richTextBox1.Text = m_printHelper.Get_PrinterSetting();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.ShowDialog();
            FontName = file.SafeFileName;
            if(FontName != "")
                textBox1.Text = FontName;
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            OpenFileDialog file = new OpenFileDialog();
            file.ShowDialog();
            //图片路径
            m_ImagePath = file.FileName;

            m_printHelper.CompanyName = "打印测试";
            m_printHelper.DrTtile.Clear();
            m_printHelper.DrTtile.Add("车辆出场收费小票");
            m_printHelper.DrContent.Clear();
            m_printHelper.DrContent.Add("0123456789", "0123456789");

            m_printHelper.PrintTicket();

            //显示打印机配置
            richTextBox1.Text = m_printHelper.Get_PrinterSetting();


            //string wmiSQL = "SELECT * FROM Win32_Printer";
            //ManagementObjectCollection printers = new ManagementObjectSearcher(wmiSQL).Get();

            //foreach (ManagementObject printer in printers)
            //{
            //    PropertyDataCollection.PropertyDataEnumerator pde = printer.Properties.GetEnumerator();

            //    while (pde.MoveNext())
            //    {
            //        richTextBox1.AppendText(pde.Current.Name + " : " + pde.Current.Value + "\r\n");

            //        //MessageBox.Show(pde.Current.Name + " : " + pde.Current.Value);
            //        //显示的是 属性名 : 属性值 的形式
            //    }
            //}
        }
    }
}
