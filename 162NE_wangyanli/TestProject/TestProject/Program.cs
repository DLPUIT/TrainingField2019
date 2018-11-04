using SquirrelFramework.Domain.Model;
using SquirrelFramework.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            var somebody = new User();
            Console.WriteLine("请输入你的学号：");
            somebody.ClassId = Console.ReadLine();
            Console.WriteLine("请输入你的名字：");
            somebody.Name = Console.ReadLine();
            Console.WriteLine("请输入你的班级：");
            somebody.ClassName = Console.ReadLine();
            Console.WriteLine("请输入你的分数：");
            somebody.Credits = int.Parse(Console.ReadLine());
            Console.WriteLine("性别是否是女？");
            somebody.Gender = bool.Parse(Console.ReadLine());
            Console.WriteLine("请输入你的小组：");
            somebody.ReportTo = Console.ReadLine();
            Console.WriteLine("请输入你的GitHub账号：");
            somebody.GitHub = Console.ReadLine();


            var dhop = new DatabaseOperation();
            dhop.Add(somebody);
            Console.ReadKey();
        }
        [Collection("User")]
        class User : DomainModel
        {
            public string ClassId { get; set; }
            public string ClassName { get; set; }
            public string Name { get; set; }
            public int Credits { get; set; }
            public bool Gender { get; set; }
            public string ReportTo { get; set; }
            public string GitHub { get; set; }

        }
        class DatabaseOperation : RepositoryBase<User>
        {

        }
    }
}
