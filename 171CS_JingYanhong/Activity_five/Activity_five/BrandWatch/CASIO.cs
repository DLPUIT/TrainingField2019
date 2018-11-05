using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity_five
{
    public class CASIO:SolarWatch,IDay, IshowTime,IshowAD
    {
        public void AfterDay()
        {
            Console.WriteLine( "XXX后是YYY天!");
        }
        public void ShowTime()
        {
            Console.WriteLine("XXXX年XX月XX日XX时XX分XX秒!");
        }
        public void ShowAD()
        {
            Console.WriteLine("CASIO FOREVER!");
        }
    }
}
