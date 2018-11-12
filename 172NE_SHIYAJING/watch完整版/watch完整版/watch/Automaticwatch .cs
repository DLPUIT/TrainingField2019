using System;
using System.Collections.Generic;
using System.Text;

namespace watch完整版
{
    public abstract class Automaticwatch:Watch , watch.IAutomaticwinding
    {
        public void Automaticwinding()
        {
            Console.WriteLine("我正在上弦");
        }
    }

    
}
