using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
           
                int[] iCards = new int[54];
                for (int i = 0; i < iCards.Length; i++)
                {
                    iCards[i] = i + 1;
                }
                //
                Random rand = new Random();
                int iTarget = 0, iCardTemp = 0;
                for (int i = 0; i < iCards.Length; i++)
                {
                    iTarget = rand.Next(0, iCards.Length);
                    iCardTemp = iCards[i];
                    iCards[i] = iCards[iTarget];
                    iCards[iTarget] = iCardTemp;
                }

                for (int i = 0; i < iCards.Length; i++)
                {
                    Console.Write("第" + (i + 1) + "个数是：" + iCards[i] + "<br/>");
                }
            
        }
    }
}
