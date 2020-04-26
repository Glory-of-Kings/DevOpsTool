using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApiTest
{
    public static class StringExtension
    {
        /// <summary>
        /// 判断字符串是否为null或者为""
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public static bool IsNullOrEmpty(this string context)
        {
            return string.IsNullOrEmpty(context);
        }

        /// <summary>
        /// 将字符串转utf8 编码的字节数组
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public static byte[] GetBytes(this string context)
        {
            return System.Text.Encoding.UTF8.GetBytes(context);
        }
    }
}
