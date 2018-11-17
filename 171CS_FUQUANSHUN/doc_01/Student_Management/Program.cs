using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Management
{
    public class Program
    {        
        private static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Black and White Student Management vision 1.0.0");
                Console.WriteLine();                        // 空行
                var executor = new Executor();
                executor.ShowHelp();
                executor.Run();
            }
            catch(Exception troubleMain)
            {
                Console.WriteLine($"程序发生异常，运行终止，详细信息："{troubleMain});
            }
        }













    }

}
