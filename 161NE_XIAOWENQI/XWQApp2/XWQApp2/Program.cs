using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XWQApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> ListRandom(List<int> myList)
            {

                Random ran = new Random();
                List newList = new List();
                int index = 0;
                int temp = 0;
                for (int i = 0; i < myList.Count; i++)
                {

                    index = ran.Next(0, myList.Count - 1);
                    if (index != i)
                    {
                        temp = myList[i];
                        myList[i] = myList[index];
                        myList[index] = temp;
                    }
                }
                return myList;
            }
            Console.ReadKey();
        }
    }
}
