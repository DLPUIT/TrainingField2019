using student.watch.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Watch
{
    public class Mywatch 
    {
        public String Name { get; set; }
     
        
        public void ShowTime ()
        {
            Console.WriteLine("某年某月某日");
        }
    }
}
