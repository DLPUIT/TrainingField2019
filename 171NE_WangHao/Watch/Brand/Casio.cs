using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Watch.interfaces;

namespace Watch.Brand
{
    class Casio : LightWatch, Icaculate
    {
        public void Caculat()
        {
            Console.WriteLine("Now computing functions are implemented");
            Console.WriteLine("X days later is...");
        }
    }
}
