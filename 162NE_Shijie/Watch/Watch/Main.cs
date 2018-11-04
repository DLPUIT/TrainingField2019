using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Watch
{
    static class JO
    {

       static void Main(string[] args)
        {
            Console.WriteLine("机械表");
            JIXIE jixie = new JIXIE();
            jixie.Name();
            jixie.Time();
            jixie.Ad();
            jixie.Ad_1();
            jixie.Action();





        }


    }
}