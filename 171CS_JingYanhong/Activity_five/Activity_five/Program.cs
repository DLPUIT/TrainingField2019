using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity_five
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var list = new List<watch>
            {
                new OMEGA{Name = "OMEGA !"},
                new CASIO {Name = "CASIO !" },
                new CITIZEN {Name = "CITIZEN !" },
                new IWC{Name = "IWC !"},
                new RADO { Name = "RADO !" },
                new TISSOT { Name = "TISSOT !" }
            };
            foreach(watch ShowWatch in list)
            {
                Console.WriteLine("I`m " + ShowWatch.Name);
                if (ShowWatch is IshowAD)
                {
                     (ShowWatch as IshowAD).ShowAD();
                }
                if (ShowWatch is IshowAD)
                {
                    (ShowWatch as IshowAD).ShowAD();
                }
                if (ShowWatch is IAutomaticChord)
                {
                    (ShowWatch as IAutomaticChord).AutomaticChord();
                }
                if (ShowWatch is IshowTime)
                {
                    (ShowWatch as IshowTime).ShowTime();
                }
                if (ShowWatch is IDay)
                {
                    (ShowWatch as IDay).AfterDay();
                }
                if (ShowWatch is ITimeKeeping)
                {
                    (ShowWatch as ITimeKeeping).Beginning();
                    (ShowWatch as ITimeKeeping).Stopping();
                    (ShowWatch as ITimeKeeping).Duration();
                }
            }
            Console.ReadKey();
        }
    }
}
