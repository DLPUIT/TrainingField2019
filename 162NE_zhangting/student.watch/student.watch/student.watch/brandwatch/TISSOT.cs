using student.watch.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Watch;

namespace student.watch
{
    class TISSOT:QuartzWatch,IStopWatch,IShowAD
    {
        public void showTime()
        {
            Console.WriteLine("TISSOT 显示时间");
        }
        public void showAdv()
        {
            Console.WriteLine("TISSOT 显示广告");
        }
        public  void showMi()
        {
            Console.WriteLine("TISSOT 秒表计时");
        }

        public void ShowAD()
        {
            throw new NotImplementedException();
        }
    }
}
