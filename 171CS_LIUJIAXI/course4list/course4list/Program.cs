using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace course4list
{
    class Program
    {
        /*
        public static int[] RandArray(int[] arr)
        {
            int[] newarr = new int[arr.Length];
            int k = 0;
            while (k < arr.Length)
            {
                int temp = new Random().Next(0, arr.Length);
                if (arr[temp] != 0)
                {
                    newarr[k] = arr[temp];
                    k++;
                    arr[temp] = 0;
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(newarr[i]);
            }
            return newarr;
        }
        */
        static void Main(string[] args)
        {
            Console.ReadKey();
        }

        private static Random rnd = new Random();
    }
}
