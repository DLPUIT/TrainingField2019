﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 黑白界面
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("DLPU 技术学习小组 管理系统 Version 1.0");
                Console.WriteLine();
                var executor = new Executor();
                executor.ShowHelp();
                executor.Run();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"发生了一个无法处理的异常，程序终止运行。详细信息:  {ex}");
            }
        }
    }
}
