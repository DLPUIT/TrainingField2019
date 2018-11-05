﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity_five
{
    class OMEGA: MechanicalWatch, ITimeKeeping, IshowTime, IshowAD,IAutomaticChord
    {
        public void ShowTime()
        {
            Console.WriteLine(DateTime.Now.ToLongDateString().ToString()+ DateTime.Now.ToLongTimeString().ToString());
        }
        public void Beginning()
        {
            Console.WriteLine("Start!");
        }
        public void Stopping()
        {
            Console.WriteLine("Stop!");
        }
        public void Duration()
        {
            Console.WriteLine("Duration!");
        }
        public void ShowAD()
        {
            Console.WriteLine("OMEGA FOREVER!");
        }
        public void AutomaticChord()
        {
            Console.WriteLine("Timing Start!");
        }

    }

}
