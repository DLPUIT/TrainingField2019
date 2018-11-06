using student.watch.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Watch
{
    public class  MechanicalWatch:Mywatch,IAutomaticWinding 
    {
        public void AutomaticWinding()
        {
             Console.WriteLine("正在上弦");
        }

        
    }
}
