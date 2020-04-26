using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectPlate
{
    internal class Program
    {
        private static string connStr = ConfigurationManager.AppSettings["connStr"];
        static void Main(string[] args)
        {
            FileSystemWatcher fileSystemWatcher = new FileSystemWatcher(System.AppDomain.CurrentDomain.BaseDirectory, "correct_plate.txt");
            fileSystemWatcher.EnableRaisingEvents = true;
            fileSystemWatcher.Changed += FileSystemWatcher_Changed;
            while (true)
            {
                System.Threading.Thread.Sleep(1000);
            }
        }

        private static void FileSystemWatcher_Changed(object sender, FileSystemEventArgs e)
        {
            var fileSystemWatcher = sender as FileSystemWatcher;
            fileSystemWatcher.EnableRaisingEvents = false;
            string content = System.IO.File.ReadAllText("correct_plate.txt");
            if (!string.IsNullOrEmpty(content))
            {
                string[] arry = content.Split('|');
                if (arry.Length >= 2)
                {
                    CorrectPlate(arry[0], arry[1]);
                }
            }
            
            fileSystemWatcher.EnableRaisingEvents = true;
        }

        private static void CorrectPlate(string plate,string enterRecordId)
        {
            try
            {
                string sqlcmd = string.Format("update box_enter_record set CredentialNO='{0}',Remark='中央收费客户端纠正车牌:{0}' where EnterRecordID='{1}'", plate, enterRecordId);
                Console.WriteLine(sqlcmd);
                MySql.Data.MySqlClient.MySqlHelper.ExecuteNonQuery(connStr, sqlcmd);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
