
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace biao2
{
    public abstract class Watch : IShowTime, IShowAD
    {
        public string ADD;
        public string Name;

        public void ShowAD()
        {
            Console.WriteLine( "Add Advisement" );
        }
        public void ShowTime()
        {
            Console.WriteLine("现在时间是");
        }
    }
}