using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 乱序算法
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] num = new int[10];
            int[] Newnum = new int[10];
            int i, r = 9;
            int n;
            int t;
            Random rand = new Random();
            for (i = 0; i < 10; i++)
            {
                num[i] = i;
            }
            for (i = 0; i < 10; i++)
            {
                n = rand.Next(0, r);
                Newnum[i] = num[n];
                t = num[n];
                num[n] = num[r];
                num[r] = t;
                r--;
            }
            for (i = 0; i < 10; i++)
            {
                Console.Write("{0} ", Newnum[i]);
            }
            Console.Read();

        }
    }
}

