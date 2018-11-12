using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biao2.watch1
{
   public class OMEGA :Mechanical ,IStopWatch
    {
        public void Starttime()
        {
            Console.WriteLine("start");
        }

        public void Stoptime()
        {
            Console.WriteLine("stop");
        }

        public void Showstopwatch()
        {
            Console.WriteLine("sequence:");
        }
    }
}
