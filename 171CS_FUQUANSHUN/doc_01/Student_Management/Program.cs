using SquirrelFramework.Domain.Model;
using SquirrelFramework.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Management
{
    using SquirrelFramework.Repository;                         // 导包
    using SquirrelFramework.Domain.Model;
    public class Program
    {
        

        private static void Main(string[] args)
        {
            Console.WriteLine("Black and White Student Management");
            Console.WriteLine();                                // 空行
           var executor = new Executor();
            executor.ShowHelp();
            Console.WriteLine(">>>");
            executor.Run();

        }













    }

}
