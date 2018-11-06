using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Amessy_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number = new int[100];
            int[] NewNumber = new int[100];
            int x = 0,
                i = 0,
                r = 9,
                t = 0,
                n = 0,
                s = 0
                ;
            Console.WriteLine("请输入您要打乱的数字个数（1-100）：");
            s = int.Parse(Console.ReadLine());
            Console.WriteLine("请输入需要打乱的数字");
            r = s - 1;
            for (i = 0; i < s; i++)
            {
                x = int.Parse(Console.ReadLine());
                number[i] = x;
            }
            Random rand = new Random();
            for (i = 0; i < s; i++)
            {
                n = rand.Next(0, r);
                NewNumber[i] = number[n];
                t = number[r];
                number[r] = number[n];
                number[n] = t;
                r--;
            }
            for (i = 0; i < s; i++)
            {
                Console.Write("{0} ", NewNumber[i]);
            }

            Console.Read();
        }
    }
}

