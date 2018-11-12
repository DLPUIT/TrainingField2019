using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Watch.interfaces;

namespace Watch
{
    public abstract class Watch : IShowAD,IShowTime
    {
        public string Name;
        public string Brand;
        public void CheckEquipments()
        {
            Console.WriteLine("Now check the device function.");
            Console.WriteLine("The Equipments are ready!");
        }

        public void CheckNetwork()
        {
            Console.WriteLine("Now check the network function.");
            Console.WriteLine("Network connectivity intact.");
        }

        public void CheckPower()
        {
            Console.WriteLine("Now check the power function.");
            Console.WriteLine("The power is ready");
        }

        public void ShowTime()
        {
            Console.WriteLine("Now displays the current time function.");
            Console.WriteLine("Now is XXXXX");
        }
    }
}
