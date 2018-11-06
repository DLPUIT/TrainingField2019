using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    class sequence
    {
        static void Main(string[] args) {
            int[] num = new int[10];
            int[] newNum = new int[10];
            int i, r = 9;
            int n;
            int tmp;
            Random rand = new Random();
            for (i= 0; i < 10; i++) {
                num[i] = i;


            } for (i= 0; i < 10; i++) {
                n = rand.Next(0, r);
                newNum[i] = num[n];
                tmp = num[n];
                num[n] = num[r];
                num[r] = tmp;
                r--;
 
               }
            for (i = 0; i < 10; i++)
            {
                Console.WriteLine("{0}",newNum[i]);
            }
            Console.ReadKey();
        }
    }
}
