using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace second01_LJJ.BrandWatch
{
    class TISSOT : WatchVariety.QuartzWatch
    {
        public void TimeStart()
        {
            Console.WriteLine("开始计时");
        }
        public void TimeEnd()
        {
            Console.WriteLine("停止计时");
        }
        public void Interval()
        {
            Console.WriteLine("间隔为...");
        }
    }
}
