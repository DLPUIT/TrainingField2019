using System;

namespace course4user
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("DLPU 技术学习小组 管理系统 Version 1.0");
            Console.WriteLine("DLPU 技术学习小组 管理系统 Version 1.0");
            var executor = new Executor();
            executor.ShowHelp();
            executor.Run();
            
        }
    }
}
