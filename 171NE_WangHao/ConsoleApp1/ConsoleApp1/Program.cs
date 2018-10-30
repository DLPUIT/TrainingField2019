using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SquirrelFramework.Domain.Model;
using SquirrelFramework.Repository;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var somebody = new user();
            Console.WriteLine("请输入班级ID");
            somebody.Classid = Console.ReadLine();
            Console.WriteLine("请输入姓名");
            somebody.Name = Console.ReadLine();
            Console.WriteLine("请输入学分");
            somebody.Credits = int.Parse(Console.ReadLine());
            Console.WriteLine("请输入性别");
            somebody.Gender = bool.Parse(Console.ReadLine());
            Console.WriteLine("请输入Leader");
            somebody.Reportto = Console.ReadLine();
            Console.WriteLine("请输入你的github帐号");
            somebody.Github = Console.ReadLine();
            var dbop = new Datebaseoperation();
     /*       dbop.Add(somebody);
            var allmember = dbop.GetAll();*/
            Console.ReadKey();
        }
    }

    class Datebaseoperation : RepositoryBase<user>
    {

    }
   
    class user:DomainModel
    {
        public string Classid { get; set; }
        public string ClassName { get; set; }
        public string Name { get; set; }
        public int Credits { get; set; }
        public bool Gender { get; set; }
        public string Reportto { get; set; }
        public string Github { get; set; }
    }
}
