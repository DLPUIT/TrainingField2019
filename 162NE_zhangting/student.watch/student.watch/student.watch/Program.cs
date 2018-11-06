using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Watch;using student.watch.Interface;

namespace student.watch
{
   internal class Program 
    {
        
        static void Main(string[] args)
        {
            var list = new List<Mywatch>
            {
             new OMEGA{Name="欧米茄"},
             new IWC { Name = "万国" },
             new CASIO{Name = "卡西欧"},
             new RADO{Name = "雷达"},
             new TISSOT{Name ="天梭"},
             new CITIZEN{Name="西铁城"}
                    
             } ;
            foreach (var watch in list )
            {
                Console.WriteLine("MY" + watch.Name);
                if (watch is Interface.ICalDay)
                {
                  (watch as Interface.ICalDay).CalDayAfterN();
                }
                if(watch is Interface.IAutomaticWinding)
                {
                    (watch as Interface.IAutomaticWinding).AutomaticWinding();

                }
                if (watch is Interface.IShowAD)
                {
                    (watch as Interface.IShowAD).ShowAD();
                }
                if (watch is Interface.IStopWatch)
                {
                    (watch as Interface.IStopWatch).StatTiming(),
                     (watch as Interface.IStopWatch).StopTiming(),
                    (watch as Interface.IStopWatch).ShowStopTime();
                }

            }
            Console.ReadKey();

        //Console.WriteLine("CASIO:");
        //var cASIO = new CASIO ();
        //cASIO.showTime();
        //cASIO.showAdv();
        //cASIO.countTime();
        //Console.WriteLine("/n");


        // Console.WriteLine("CITIZEN:");
        // CITIZEN cITIZEN = new CITIZEN();
        // cITIZEN.showTime();
        // cITIZEN.showAdv();
        // Console.WriteLine("/n");

        // Console.WriteLine("TISSOT:");
        //    TISSOT tISSOT = new TISSOT();
        //    tISSOT.showTime();
        //    tISSOT.showAdv();
        //    tISSOT.showMi();

        // Console.WriteLine("RADO:");
        //    RADO rADO = new RADO();
        //    rADO.ShowTime();
           
        // Console.WriteLine("OMEGA");
        //    OMEGA oMEGA = new OMEGA();
        //    oMEGA.showTime();
        //    oMEGA.showAdv();
        //    oMEGA.showMi();
        //    Console.WriteLine("IWC");
        //    IWC iWC = new IWC();
        //    iWC.showTime();
        //    iWC.showAdv();
            
      
            

        }
    }
}
