using System;
using System.Collections.Generic;
using System.Text;

namespace Watch
{
    public class MechanicaWatch:Watch,IAutomaticWinding
    {
        public void AutomaticWinding()
        {
            Console.WriteLine("我正在上弦");
        }
    }
}
