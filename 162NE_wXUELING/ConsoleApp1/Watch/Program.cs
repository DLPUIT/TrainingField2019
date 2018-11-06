using System;
using System.Collections.Generic;
using Watch.Kindwatch;

namespace Watch
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<Watch>
            {
                new CASIO(),
                new OMEGA
                {
                    Name="Omega"
                }

            };
            foreach(Watch watch in list)
            {
                Console.WriteLine("I am" + watch.Name);
                    if (watch is TISSOT)
                {
                    (watch as TISSOT).Starting();
                    (watch as TISSOT).Stoptiming();
                    (watch as TISSOT).Showtime();


                }
                    if(watch is OMEGA)
                {
                    (watch as OMEGA).Showtime();
                    (watch as OMEGA).Starting();
                    (watch as OMEGA).Stoptiming();

                }
                    if(watch is CASIO)
                {
                    (watch as CASIO).Caldayafter();
        
                }
            }
           
        }
    }
}
