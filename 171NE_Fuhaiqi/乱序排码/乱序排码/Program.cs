using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 乱序排码
{
    class Program
    {
        delegate void Action();
        static void Main(string[] args)
        {
            List<Action> methods = new List<Action> { H,Y,R,A,M };

            for (int i = 0; i < 100; i++)
            {
                var j = rnd.Next(methods.Count);
                var s= methods[j];
                s();
            }
            Console.WriteLine("...............按任意键结束");
            Console.ReadKey();
        }
        private static Random rnd = new Random();
        static void H()
        {
            Console.Write("h");
        }
        static void Y()
        {
            Console.Write("y");
        }
        static void R()
        {
            Console.Write("r");
        }
        static void A()
        {
            Console.Write("a");
        }
        static void M()
        {
            Console.Write("m");
        }

    }
}

