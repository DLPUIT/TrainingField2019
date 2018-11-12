using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biao2.watch1
{
    public class TISSOT : Quartz, IStopWatch
    {
        public void Starttime()
        {
            Console.WriteLine("start");
        }

        public void Stoptime()
        {
            Console.WriteLine("stopjishi");
        }

        public void Showstopwatch()
        {
            Console.WriteLine("alltime");
        }
    }
}