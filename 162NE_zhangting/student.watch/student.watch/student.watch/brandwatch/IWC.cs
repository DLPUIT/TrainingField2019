using student.watch.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Watch;

namespace student.watch
{
    class IWC:MechanicalWatch,IStopWatch,IShowAD
    {
        public string Name { get; internal set; }

    
       
        public  void StartTiming()
        {
            Console.WriteLine("");
        }
        public void StopTiming()
        {
            Console.WriteLine("");
        }
        public void ShowStopTime()
        {
            Console.WriteLine("");

        }

        public void StatTiming()
        {
            throw new NotImplementedException();
        }

        public void ShowAD()
        {
            throw new NotImplementedException();
        }
    }
}
