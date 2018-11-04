using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace second02_LJJ
{
    class Program
    {
        static void Main(string[] args)
        {
            int i,n,value,x = 9;
            List<int> list = new List<int>(10);
            List<int> newlist = new List<int>(10);
            for (i = 0; i < 10; i++)
            {
                list.Add(i);
            }
            Console.Write("原数组为:");
            foreach (int p in list)
            {
                Console.Write( p + " ");
            }
            Random random = new Random();
            Console.Write("新数组为:");
            for(i = 0; i < 10; i++)
            {
                n = random.Next(0, x);
                newlist.Add(list[n]);
                value = list[x];
                list[x] = list[n];
                list[n] = value;
                x--;
            }
            foreach (int q in list)
            {
                Console.Write(q + " ");
            }
            Console.ReadKey();
        }
    }
}
