using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity_five
{
    public abstract class watch:IshowTime,IshowAD
    {
        public string Name;
        public string AD;


        public void ShowTime()
        {
            Console.WriteLine("Time is XX:XX:XX!");
        }
        public void ShowAD()
        {
            Console.WriteLine(this.Name + "'s AD : " + this.AD);
        }
    }
}
