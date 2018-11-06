using System;
using System.Collections.Generic;
using watch完整版.watch;

namespace watch完整版
{
    public abstract class Watch : watch.IShowTime, watch.IShowAD
    {
        public string Name;
        public void Showtime()
        {
            Console.WriteLine("现在是北京时间20：00");

        }
        public void Showad()
        {
            Console.WriteLine("未来离不开手表");

        }

        public void ShowTime()
        {
            throw new NotImplementedException();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<Watch>
            {
                new OMEGA{Name= "A 's watch"},
                new IWC{Name= "B 's watch"},
                new CASIO{Name= "C's  watch"},
                new TISSOT{Name= "D 's watch"},
                new RODO{Name= "E 's watch"},
                new CITIZEN{ Name="F's watch"},
            };
            foreach (var Watch in list)
            {
                Console.WriteLine("我是"+Watch.Name);
                if (Watch is Icalutime)
                {
                  (Watch as Icalutime).Calutime();
                }
                if (Watch is Iwinding)
                {
                  (Watch as Iwinding).StartTime() ;
                  (Watch as Iwinding).StopTime();
                  (Watch as Iwinding).ShowSopTime();
                }
                if (Watch is IAutomaticwinding)
                {
                    (Watch as IAutomaticwinding).Automaticwinding();
                }
            }

        }
    }
}
