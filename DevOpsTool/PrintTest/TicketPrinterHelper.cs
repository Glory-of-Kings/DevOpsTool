using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using PrintTest;
using System.IO;


namespace PrintTest
{
    public class TicketPrinterHelper
    {
        private PrintDocument pd1;
        private Font printFont;
        private string _companyName = "打印测试";
        private List<string> drTitle = new List<string>();
        private Dictionary<string, string> drContent = new Dictionary<string, string>();

        public string CompanyName { get { return _companyName; } set { _companyName = value; } }

        public List<string> DrTtile
        {
            get { return this.drTitle; }
            set { this.drTitle = value; }
        }

        public Dictionary<string, string> DrContent
        {
            get { return this.drContent; }
            set { this.drContent = value; }
        }

        public TicketPrinterHelper(List<string> title, Dictionary<string, string> content)
        {
            this.drTitle = title;
            this.drContent = content;
        }
        public TicketPrinterHelper()
        { }

        public void PrintTicket()
        {
            try
            {
                this.pd1 = new PrintDocument();
                this.pd1.PrintPage += new PrintPageEventHandler(this.pd_PrintPage);
                this.pd1.PrintController = new StandardPrintController();
                ThreadPool.QueueUserWorkItem(new WaitCallback(printTicket));
            }
            catch (Exception)
            { 
            }
        }

        private void printTicket(object obj)
        {
            try
            {
                this.pd1.Print();
            }
            catch (Exception)
            { }
        }

        private void pd_PrintPage(object sender, PrintPageEventArgs ev)
        {
            try
            {

                //字体
                string UseFontName;
                if (Form1.FontName == null)
                {
                    UseFontName = "Arial";
                }
                else
                {
                    UseFontName = Form1.FontName;
                }
                //UseFontName = "Segoe Print";


                float yPos = 0f;
                float leftMargin = 1f;
                float topMargin = 1f;
                float gap = 3f;
                float bigFontSize = 9f;
                float smallFontSize = 8f;


                this.printFont = new Font(UseFontName, bigFontSize);
                yPos += topMargin + this.printFont.GetHeight(ev.Graphics) + gap;
                string tmp = CompanyName;

                //切换为半角字符
                if (!string.IsNullOrWhiteSpace(tmp))
                {
                    tmp = ToDBC(tmp);
                    if (tmp.Length > 13)
                    {
                        tmp = tmp.Substring(0, 13) + "...";
                    }
                }

                int iMax = 50;
                int iTempCount = Encoding.Default.GetByteCount(tmp);
                if (iTempCount > iMax)
                    iTempCount = iMax;
                tmp = tmp.PadLeft((iMax - iTempCount) / 2,  ' ');
                if (tmp.Length >= 50)
                    tmp = tmp.Substring(0, 50);
                StringFormat sf = new StringFormat();
                ev.Graphics.DrawString(tmp, this.printFont, Brushes.Black, leftMargin, yPos, sf);
                yPos += topMargin + this.printFont.GetHeight(ev.Graphics) + gap;
                foreach (string s in this.drTitle)
                {
                    iTempCount = Encoding.Default.GetByteCount(s);
                    if (iTempCount > iMax)
                        iTempCount = iMax;

                    tmp = tmp.PadLeft((iMax - iTempCount) / 2, ' ');
                    if (tmp.Length >= 50)
                        tmp = tmp.Substring(0, 50);
                    ev.Graphics.DrawString(tmp, this.printFont, Brushes.Black, leftMargin, yPos, sf);
                    yPos += topMargin + this.printFont.GetHeight(ev.Graphics) + gap + 3f;
                }

                this.printFont.Dispose();
                this.printFont = new Font(UseFontName, smallFontSize);
                this.drContent.Add("操作时间", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                foreach (KeyValuePair<string, string> kvp in this.drContent)
                {
                    tmp = kvp.Key + ":" + kvp.Value;
                    ev.Graphics.DrawString(tmp, this.printFont, Brushes.Black, leftMargin, yPos, sf);
                    yPos += this.printFont.GetHeight(ev.Graphics) + gap + 3f;
                    ev.Graphics.DrawString(tmp, this.printFont, Brushes.White, leftMargin, yPos, sf);
                    yPos += this.printFont.GetHeight(ev.Graphics) + gap + 3f;
                }

                ev.Graphics.DrawString("   \r\n", this.printFont, Brushes.Black, leftMargin, yPos, sf);
                sf.Dispose();
                this.printFont.Dispose();
            }
            catch(Exception)
            { 
            }
        }

        //全角转半角
        public static string ToDBC(string input)
        {
            char[] arr = input.ToCharArray();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 12288)
                {
                    arr[i] = (char)32;
                    continue;
                }
                if (arr[i] > 65280 && arr[i] < 65375)
                {
                    arr[i] = (char)(arr[i] - 65248);
                }
            }
            return new string(arr);
        }

        //获取打印机配置
        public string Get_PrinterSetting()
        {
            try
            {
                string printsetting = "";

                //读取图片路径
                Image newImage = null;
                //空路径
                if (Form1.m_ImagePath != null)
                {
                    //空字节
                    System.IO.FileInfo f= new FileInfo(Form1.m_ImagePath);
                    if (f.Length != 0)
                    {
                        newImage = Image.FromFile(Form1.m_ImagePath);
                    }
                }

                //初始化pd1
                if (pd1 == null)
                {
                    this.pd1 = new PrintDocument();
                    this.pd1.PrintPage += new PrintPageEventHandler(this.pd_PrintPage);
                    this.pd1.PrintController = new StandardPrintController();
                }

                printsetting += "打印机名:";
                printsetting += pd1.PrinterSettings.PrinterName.ToString() + "\r\n";
                //printsetting += "支持打印类型:";
                //printsetting += pd1.PrinterSettings.PrinterResolutions.ToString() + "\r\n";
                printsetting += "打印文件名:";
                printsetting += pd1.PrinterSettings.PrintFileName.ToString() + "\r\n";
                printsetting += "是否支持彩色打印:";
                printsetting += pd1.PrinterSettings.SupportsColor.ToString() + "\r\n";
                printsetting += "是否打印该类型图像:";
                if (newImage != null)
                    printsetting += pd1.PrinterSettings.IsDirectPrintingSupported(newImage).ToString() + "\r\n";
                else
                    printsetting += "无读取图像";
                //newImage.Dispose();

                return printsetting;
            }
            catch(Exception ex)
            {
                string str = "发生报错,\r\n";
                str += ex.ToString();
                return str;
            }
        }
    }



}
