using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace Telnet
{
    class Program
    {
        static void Main(string[] args)
        {
            int loopSeconds = int.Parse(ConfigurationManager.AppSettings["LoopSeconds"]);
            Task.Factory.StartNew(() =>
            {
                while (true)
                {
                    if (CheckState())
                    {
                        Log("连接成功");
                    }
                    else
                    {
                        Log("连接失败");
                        KillProcess();
                    }
                    System.Threading.Thread.Sleep(loopSeconds * 1000);
                }
            });

            while (true)
            {
                System.Threading.Thread.Sleep(1000);
            }
        }

        private static void KillProcess()
        {
            try
            {
                string processName = ConfigurationManager.AppSettings["ProcessName"];
                var proc = Process.GetProcesses().Where(x => x.ProcessName.Contains(processName)).FirstOrDefault();//获取已开启的所有进程
                if (proc != null)
                {
                    proc.Kill();
                    Log("杀死进程：" + proc.ProcessName);
                    string serviceName = ConfigurationManager.AppSettings["ServiceName"];
                    var service = ServiceController.GetServices().Where(x => x.ServiceName.Contains(serviceName)).FirstOrDefault();
                    if (service != null)
                    {
                        service.Start();
                        Log("启动服务：" + service.ServiceName);
                    }
                }
                else
                {
                    string serviceName = ConfigurationManager.AppSettings["ServiceName"];
                    var service = ServiceController.GetServices().Where(x => x.ServiceName.Contains(serviceName)).FirstOrDefault();
                    if (service != null)
                    {
                        service.Start();
                        Log("启动服务：" + service.ServiceName);
                    }
                }
            }
            catch (Exception ex)
            {
                Log(ex.ToString());
            }
        }

        private static bool CheckState()
        {
            String ipAddr = ConfigurationManager.AppSettings["IpAddr"];
            int port = int.Parse(ConfigurationManager.AppSettings["Port"]);
            IPAddress ip = IPAddress.Parse(ipAddr);
            try
            {
                IPEndPoint point = new IPEndPoint(ip, port);
                using (Socket sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp))
                {
                    sock.Connect(point);
                    sock.Close();
                }
                return true;
            }
            catch (SocketException ex)
            {
                Log(ex.ToString());
                return false;
            }
        }

        private static void Log(string message)
        {
            string timeString = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            string log = timeString + ":" + message;
            if (!Directory.Exists("logs"))
            {
                Directory.CreateDirectory("logs");
            }
            string path = "logs\\" + DateTime.Now.ToString("yyyyMMdd") + ".log";
            Console.WriteLine(log);
            using (StreamWriter sw = new StreamWriter(path, true))
            {
                sw.WriteLine(log, Encoding.UTF8);
                sw.Close();
            }
        }
    }
}
