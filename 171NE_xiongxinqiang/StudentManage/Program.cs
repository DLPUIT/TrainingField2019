using System;
namespace Studentmanage
{
    public class Program
    {
        private static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("学生管理系统 熊先生版 Version 1.0");
                Console.WriteLine();
                var executor = new Executor();
                executor.Showhelp();
                executor.Run();
            }
            //异常处理
            catch (Exception ex)
            {
                Console.WriteLine($"发生了一个无法处理的异常，程序终止运行。详细信息:  {ex}");
            }
        }
    }
}
