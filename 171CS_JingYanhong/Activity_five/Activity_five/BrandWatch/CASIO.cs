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
            Console.WriteLine(DateTime.Now.ToLongDateString().ToString() + DateTime.Now.ToLongTimeString().ToString());
        }
        public void ShowAD()
        {
            Console.WriteLine("CASIO FOREVER!");
        }
    }
}
