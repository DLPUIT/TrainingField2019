using Microsoft.Analytics.Interfaces;
using Microsoft.Analytics.Types.Sql;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace biao2
{
    public abstract class Mechanical : Watch, IAutomaticWinding
    {
        public void AutomaticWinding()
        {
            Console.WriteLine("可以上线");
        }
    }
}