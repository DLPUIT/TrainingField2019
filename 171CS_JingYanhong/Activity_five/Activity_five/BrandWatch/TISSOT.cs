using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity_five
{
    public class TISSOT: QuartzWatch, ITimeKeeping, IshowTime, IshowAD
    {
        public  void Beginning()
        {
            Console.WriteLine("Start!");
        }
        public void Stopping()
        {
            Console.WriteLine("Stop!");
        }
        public  void Duration()
        {
            Console.WriteLine("Duration!");
        }
        public void ShowTime()
        {
            Console.WriteLine("XXXX年XX月XX日XX时XX分XX秒!");
        }
        public void ShowAD()
        {
            Console.WriteLine("ISSOT FOREVER!");
        }
    }
}
