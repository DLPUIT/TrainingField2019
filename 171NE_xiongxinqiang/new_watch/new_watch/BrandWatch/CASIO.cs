using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace new_watch
{
    public class CASIO : SloarWatch, ICalDay
    {
        public void ShowDayafter()
        {
            Console.WriteLine("N天后是");
        }
    }
}
