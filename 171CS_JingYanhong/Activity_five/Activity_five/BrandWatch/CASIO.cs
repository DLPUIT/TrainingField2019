using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity_five
{
    public class CASIO:SolarWatch,IDay, IshowTime,IshowAD
    {
        public void AfterDay()
        {
            int n = 0;
            Console.WriteLine("请输入您要查询的日期距离今天的天数：");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine( n + "天之后是：" + DateTime.Now.AddDays(n));
        }
        public void ShowTime()
        {
            Console.WriteLine(DateTime.Now.ToLongDateString().ToString() + DateTime.Now.ToLongTimeString().ToString());
        }
        public void ShowAD()
        {
            Console.WriteLine("CASIO FOREVER!");
        }
    }
}
