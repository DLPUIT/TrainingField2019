using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AboutWatch
{
    class Program
    {
        static void Main(string[] args)
        {
             var list = new List<Watch>
            {
             //   new OMEGA {Name = "omega"},
                new OMEGA {Name = "omega"},
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
                    (watch is OMEGA).StartTiming();
                    (watch is OMEGA).StopTiming();
                    (watch is OMEGA).ShowStopWatch();
                }
                if (watch is CASIO)
                {
                    (watch is CASIO).CalDayAfterN();
                    (watch is CASIO).StartTiming();
                    (watch is CASIO).StopTiming();
                    (watch is CASIO).ShowStopWatch();
                }
                if (watch is TISSOT)
                {
                    (watch is TISSOT).StartTiming();
                    (watch is TISSOT).StopTiming();
                    (watch is TISSOT).ShowStopWatch();
                }
            }

            Console.ReadKey(true);
         }
    }
}
