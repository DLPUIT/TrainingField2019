using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list
{
    class arr
    {
        public string runCount { get; private set; }

        public int[] m3(int[] arr)
        {
            int[] arr2 = new int[arr.Length];
            int count = arr.Length;
            int cbRandCount = 0;// 索引
            int cbPosition = 0;// 位置
            int k = 0;
            do
            {
                int runCount = 0;
                runCount++;
                Random rand = new Random();
                int r = count - cbRandCount;
                cbPosition = rand.nextInt(r);
                arr2[k++] = arr[cbPosition];
                cbRandCount++;
                arr[cbPosition] = arr[r - 1];// 将最后一位数值赋值给已经被使用的cbPosition
            } while (cbRandCount < count);
            Console.WriteLine("m3运算次数  = " + runCount);
            return arr2;
        }

    }
}
