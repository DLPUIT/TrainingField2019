using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity_five
{
    public class CITIZEN: SolarWatch, IshowTime, IshowAD
    {
        public void ShowTime()
        {
            Console.WriteLine("XXXX年XX月XX日XX时XX分XX秒!");
        }
        public void ShowAD()
        {
            Console.WriteLine("CITIZEN FOREVER!");
        }
    }
}
