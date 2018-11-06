using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student.watch
{
    

    using System;
    using System.Collections.Generic;
    using text3;

    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            // 泛型容器
            var list = new List<Watch>
            {
                new OMEGA {Name = "MYW's omega."},
                new OMEGA {Name = "KKK's omega."},
                new CASIO(),
                new TISSOT()
            };

            foreach (Watch watch in list)
            {
                Console.WriteLine("I'm " + watch.Name);

                if (watch is ICalDay)
                {
                    (watch as ICalDay).CalDayAfterN();
                }
                if (watch is IStopWatch)
                {
                    (watch as IStopWatch).StartTiming();
                    (watch as IStopWatch).StopTiming();
                    (watch as IStopWatch).ShowStopWatch();
                }
            }

            CASIO c1 = new CASIO();
            Watch c2 = new CASIO();
            CASIO c3 = c2 as CASIO;

            Watch w1 = new CASIO();
            Watch w2 = new OMEGA();

            IStopWatch stopWatch = new CASIO();
            IStopWatch stopWatch2 = new OMEGA();

            foreach (var watch in list)
            {
                if (watch is OMEGA)
                {
                }
                if (watch is CASIO)
                {
                }
                if (watch is TISSOT)
                {
                }
            }

            Console.ReadKey(true);
        }
    }
}