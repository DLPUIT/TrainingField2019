using System;
using System.Collections.Generic;
using System.Text;

namespace Watch
{
    public class Watch:IShowAD,IShowTime
    {
        public String Name;
        public void ShowAD()
        {
            String ADDescription="";
            Console.WriteLine(Name+"在做广告"+ADDescription);
        }
        public void ShowTime()
        {
            Console.WriteLine("现在是X年X月X日XXX");
        }
    }
}
