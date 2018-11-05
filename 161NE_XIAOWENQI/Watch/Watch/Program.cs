using System;
using System.Collections.Generic;

namespace Watch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var list = new List<Watch>
            {
                new CASIO(),
                new OMEGA{Name="my omega"}
            };
            foreach(Watch watch in list)
            {
                Console.WriteLine("I am"+watch.Name);
                if(watch is TISSOT)
                {
                    (watch as TISSOT).StartTiming();
                    (watch as TISSOT).StopTiming();
                    (watch as TISSOT).ShowStopTime();
                }
                if (watch is OMEGA)
                {
                    (watch as OMEGA).StartTiming();
                    (watch as OMEGA).StopTiming();
                    (watch as OMEGA).ShowStopTime();
                }
                if (watch is CASIO)
                {
                    (watch as CASIO).CalDayAfterN();
                }
            }

        }
       //Console.ReadKey(true);
    }
}
