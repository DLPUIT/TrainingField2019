using System;
using System.Collections.Generic;

namespace ConsoleApplication2//按照abcd顺序输入四个字母然后进行随机排序
{
    class Program
    {
        delegate void Action();

        static void Main(string[] args)
        {
            List<Action> methods = new List<Action> { A, B, C, D };
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

        static void A()
        {
            Console.Write("A");
        }

        static void B()
        {
            Console.Write("B");
        }

        static void C()
        {
            Console.Write("C");
        }

        static void D()
        {
            Console.Write("D");
        }
    }
}
