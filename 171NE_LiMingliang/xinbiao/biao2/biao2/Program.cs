using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using biao2.watch;
using biao2.watch1;

namespace biao2
{
    internal class Program //包内使用时iternal,私人private public包内外
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1231313");
            List<Watch> list = new List<Watch>
            {
                new CASIO {Name = " CASIO.",ADD = "CASIO's AD"},
                new CITIZEN {Name = "CITIZEN.",ADD = "CITIZEN's AD"},
                new IWC {Name = " IWC.",ADD = "IWC's AD"},
                new OMEGA {Name = " OMEGA.",ADD = "OMEGA's AD"},
                new RADO {Name = " RADO.",ADD = "RADO's AD"},
                new TISSOT {Name = " TISSOT.",ADD = "TISSOT's AD"}
            };

            foreach (Watch watch in list)
            {
                Console.WriteLine("I'm " + watch.Name);

                if (watch is ICalDay)
                {
                    (watch as ICalDay).ShowDayafter();
                }
                if (watch is IStopWatch)
                {
                    (watch as IStopWatch).Starttime();
                    (watch as IStopWatch).Stoptime();
                    (watch as IStopWatch).Showstopwatch();
                }
                if (watch is IShowAD)
                {
                    (watch as IShowAD).ShowAD();
                }
                if (watch is IShowTime)
                {
                    (watch as IShowTime).ShowTime();
                }
                if (watch is IAutomaticWinding)
                {
                    (watch as IAutomaticWinding).AutomaticWinding();
                }
            }

            Console.ReadKey(true);
        }
    }
}
