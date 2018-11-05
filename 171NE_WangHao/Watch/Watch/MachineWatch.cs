using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Watch.interfaces;

namespace Watch
{
    class MachineWatch : Watch, Iautolock
    {
        public void AutoLock()
        {
            Console.WriteLine("Now display automatic lock function.");
            Console.WriteLine("Finished!");
        }
    }
}
