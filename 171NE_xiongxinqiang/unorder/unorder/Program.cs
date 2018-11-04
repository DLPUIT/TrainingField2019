using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unorder
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] order = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] unorder = new int[10];
            bool[] ass = new bool[10];
            Random source = new Random();
            for (int i = 0; i < 10; i++)
            {
                int destorder = 0;     //随机数保存空间
                bool foundorder = false;
                while (foundorder == false)
                {
                    //生成一个0到10之间的随机数
                    destorder = source.Next(10);
                    if (ass[destorder] == false)
                    {
                        foundorder = true;
                    }
                }
                ass[destorder] = true;
                unorder[destorder] = order[i];
            }
            for (int j = 0; j < 10; j++)
            {
                Console.WriteLine("{0}", unorder[j]);
            }
            Console.ReadKey();
        }
    }
}
