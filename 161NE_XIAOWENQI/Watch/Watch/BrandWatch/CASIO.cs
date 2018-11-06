using System;
using System.Collections.Generic;
using System.Text;

namespace Watch
{
    public class CASIO : SolarWatch, ICalDay
    {
        public void CalDayAfterN()
        {
            Console.WriteLine("N天之后是第M天");
        }
    }
}
