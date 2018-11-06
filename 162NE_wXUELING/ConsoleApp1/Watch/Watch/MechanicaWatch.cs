using System;
using System.Collections.Generic;
using System.Text;

namespace Watch
{
    class MechanicaWatch:Watch,IautomaticWinding
    {
        public void AutomaticWinding()
        {
            Console.WriteLine("I am winding up");
        }
    }
}
