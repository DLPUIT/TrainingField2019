using System;

namespace list
{
    class program
    {
        public static void main(String[] args)
        {
            int[] arr = new int[10];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i + 1;
            }
            TestArray t = new TestArray();
            arr = t.m1(arr);
            print(arr);
            arr = t.m2(arr);
            print(arr);
            arr = t.m3(arr);
            print(arr);
        }

        public static void print(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i] + " ");
                Console.WriteLine(); // System.out.println();
                runCount = 0;
            }
        }
            }
}
