using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity_five
{
    //机械表
    public abstract class MechanicalWatch:watch,IAutomaticChord
    {
       public void AutomaticChord()
        {
            Console.WriteLine("Timing Start!");
        }
    }
}
