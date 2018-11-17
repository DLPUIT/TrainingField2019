using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 代码调试专用
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string url = "http://www.baidu.com";
            char[] str = url.ToCharArray();
            char[] str1 = new char[7];
            str1[0] = str[0];
            str1[1] = str[1];
            str1[2] = str[2];
            str1[3] = str[3];
            str1[4] = str[4];
            str1[5] = str[5];
            str1[6] = str[6];
            Console.WriteLine(str);
            Console.WriteLine(str1);
            string str2 = new string(str1);
            Console.WriteLine(str2);
            if (str2 == "http://")
            {
                Console.WriteLine("正确");
            }
            else
            {
                Console.WriteLine("错误");
            }
        }
    }
}
