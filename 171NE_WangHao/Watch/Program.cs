using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Watch.Brand;
using Watch.interfaces;

namespace Watch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome!");
            Console.WriteLine();
            var AllWatch = new List<Watch>
            {
                new Omega{Name="watch1"},
                new Casio{Name="watch2"},
                new Iwc {Name = "watch3" },
                new Rado{Name = "watch4" },
                new Tissot {Name = "watch5" },
            };
            foreach(var wat in AllWatch)
            {
                Console.WriteLine("I'm " + wat.Name+".");
                if (wat is Iautolock)
                    (wat as Iautolock).AutoLock();
                if (wat is Icaculate)
                    (wat as Icaculate).Caculat();
                if (wat is Iselfclock)
                    (wat as Iselfclock).SelfClock();
                if(wat is IShowAD)
                {
                    (wat as IShowAD).CheckEquipments();
                    (wat as IShowAD).CheckNetwork();
                    (wat as IShowAD).CheckPower();
                }
                if (wat is IShowTime)
                    (wat as IShowTime).ShowTime();
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
