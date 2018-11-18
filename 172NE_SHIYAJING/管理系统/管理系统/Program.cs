using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 管理系统
{
  
    public class Program
    {
       
        private static void Main(string[] args)
        {
            try
            {
            Console.WriteLine("\t\t\t\t\tDLPU 技术学习小组 管理系统 Version");
            Console.WriteLine();
            Executor executor = new Executor();
            executor.Showhelp();
            executor.Run();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"发生了一个无法处理的异常，程序终止运行。详细信息:  {ex}");
            }
        }
    
    }
}
