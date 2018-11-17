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
            foreach(var i in url)
            {
                str1[i] = str[i];
                if(str1.Length == 7)
                    break;
            }            
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
