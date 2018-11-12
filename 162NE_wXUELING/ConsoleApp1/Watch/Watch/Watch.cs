using System;
using System.Collections.Generic;
using System.Text;

namespace Watch
{
    class Watch:Ishowad,Ishowtime
    {
        public String Name;
        public void Showad()
        {
            string Addescription = "very good";
            Console.WriteLine(Name + "在做广告" + Addescription);

        }
        public void Showtime()
        {
            Console.WriteLine("It's x年x月x日xxx");

        }
    }
}
