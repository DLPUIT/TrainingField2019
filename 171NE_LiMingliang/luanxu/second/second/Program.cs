using System;
using System.Collections.Generic;

namespace ConsoleApplication2
{
    class Program
    {
        delegate void Action();

        static void Main(string[] args)
        {
            List<Action> methods = new List<Action> { Q, W, E, R };
            for (int i = 0; i < 1000; ++i)
            {
                var j = rnd.Next(methods.Count);
                var m = methods[j];
                m();
            }
            Console.WriteLine("...............按任意键结束");
            Console.ReadKey();
        }

        private static Random rnd = new Random();

        static void Q()
        {
            Console.Write("Q");
        }

        static void W()
        {
            Console.Write("W");
        }

        static void E()
        {
            Console.Write("E");
        }

        static void R()
        {
            Console.Write("R");
        }
    }
}
