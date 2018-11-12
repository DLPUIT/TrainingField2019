using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace new_watch
{
    //public：包内外都可以被访问
    //internal：包内访问
    //private：私有包内包外都不可以访问

    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //var list = new List<Watch> 语法糖
            List<Watch> list = new List<Watch>
            {
                new CASIO {Name = "Calvert's CASIO.",ADDscription = "CASIO's AD"},
                new CITIZEN {Name = "Calvert's CITIZEN.",ADDscription = "CITIZEN's AD"},
                new IWC {Name = "Calvert's IWC.",ADDscription = "IWC's AD"},
                new OMEGA {Name = "Calvert's OMEGA.",ADDscription = "OMEGA's AD"},
                new RADO {Name = "Calvert's RADO.",ADDscription = "RADO's AD"},
                new TISSOT {Name = "Calvert's TISSOT.",ADDscription = "TISSOT's AD"}
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
