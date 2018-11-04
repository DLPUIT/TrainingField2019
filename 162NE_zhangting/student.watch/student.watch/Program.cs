using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student.watch
{
    class Program 
    {
        
        static void Main(string[] args)
        {
        Console.WriteLine("CASIO:");
        CASIO cASIO = new CASIO ();
        cASIO.showTime();
        cASIO.showAdv();
        cASIO.countTime();
        Console.WriteLine("/n");


         Console.WriteLine("CITIZEN:");
         CITIZEN cITIZEN = new CITIZEN();
         cITIZEN.showTime();
         cITIZEN.showAdv();
         Console.WriteLine("/n");

         Console.WriteLine("TISSOT:");
            TISSOT tISSOT = new TISSOT();
            tISSOT.showTime();
            tISSOT.showAdv();
            tISSOT.showMi();

         Console.WriteLine("RADO:");
            RADO rADO = new RADO();
            rADO.showTime();
            rADO.showAdv();
         Console.WriteLine("OMEGA");
            OMEGA oMEGA = new OMEGA();
            oMEGA.showTime();
            oMEGA.showAdv();
            oMEGA.showMi();
            Console.WriteLine("IWC");
            IWC iWC = new IWC();
            iWC.showTime();
            iWC.showAdv();
            

        }
    }
}
