
using second01_LJJ.BrandWatch;
using second01_LJJ.WatchVariety;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace second01_LJJ
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<Watch>()
            {
                new OMEGA{Name = "OMEGA" },
                new IWC{Name = "IWC" },
                new CASIO{Name = "CASIO" },
                new CITIZEN{Name = "CITIZEN" },
                new TISSOT{Name = "TISSOT" },
                new RADO{Name = "RADO" }
            };
            Watch a = new Watch();
            OMEGA b = new OMEGA();
            TISSOT c = new TISSOT();
            CASIO d = new CASIO();
            MechanicalWatch e = new MechanicalWatch();
            foreach (Watch watch in list)
            {
                Console.WriteLine(watch.Name);
                a.ShowTime();
                Console.Write(watch.Name);
                a.ShowAd();
                if (watch is OMEGA || watch is TISSOT)
                {
                    b.TimeStart();
                    b.TimeEnd();
                    b.Interval();
                }
                if (watch is CASIO)
                {
                    d.Future();
                }
                if (watch is MechanicalWatch)
                {
                    e.AutoWinding();

                }
                Console.WriteLine("\n");
            }
            Console.ReadKey();
        }
    }
}
