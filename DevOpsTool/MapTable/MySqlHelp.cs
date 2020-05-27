using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;


namespace MapTable
{
    public static class MySqlHelp
    {
        public static string ConnectionStr;

        public static DataTable ExecuteSql(string connStr, string sql)
        {
            MySqlConnection conn = new MySqlConnection(ConnectionStr);
            try
            {
                conn.Open();

                DataTable dt = MySqlHelper.ExecuteDataset(connStr, sql, null).Tables[0];
                conn.Close();
                return dt;
            }
            catch (Exception ex)
            {
                conn.Close();
                return null;
            }
        }

        public static int ExecuteNonQuery(string connStr, string sql, params MySqlParameter[] parms)
        {
            MySqlConnection conn = new MySqlConnection(ConnectionStr);
            try
            {
                conn.Open();
                int iResult = 0;

                iResult = MySqlHelper.ExecuteNonQuery(connStr, sql, parms);
                conn.Close();
                return iResult;
            }
            catch (Exception ex)
            {
                conn.Close();
                return -1;
            }
        }

        public static bool TestConn(string connStr)
        {
            MySqlConnection conn = new MySqlConnection(ConnectionStr);
            bool canConn = false;
            try
            {
                conn.Open();
                conn.Close();
                canConn = true;
            }
            catch (Exception ex)
            {
                conn.Close();
            }
            return canConn;
        }
    }
}
