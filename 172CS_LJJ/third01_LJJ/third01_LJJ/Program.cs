using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace third01_LJJ
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<Watch>
            {
                new OMEGA {Name = "OMEGA."},
                new CASIO {Name = "CASIO"},
                new CITIZEN(),
                new TISSOT(),
                new RADO(),
                new IWC()
            };

            foreach (Watch watch in list)
            {
                Console.WriteLine("I'm " + watch.Name);

                if (watch is ICalday)
                {
                    (watch as ICalday).calday();
                }
                if (watch is ITiming)
                {
                    (watch as ITiming).TimeStart();
                    (watch as ITiming).TimeEnd();
                    (watch as ITiming).Interval();
                }
                if (watch is IShowAd)
                {
                    (watch as IShowAd).ShowAd();
                }
                if (watch is IShowTime)
                {
                    (watch as IShowTime).ShowTime();
                }
                if (watch is IAutoWinding)
                {
                    (watch as IAutoWinding).AutoWinding();
                }
                Console.ReadKey();
            }
        }
    }
}
