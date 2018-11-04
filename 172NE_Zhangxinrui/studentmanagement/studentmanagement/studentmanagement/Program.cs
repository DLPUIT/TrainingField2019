using SquirrelFramework.Domain.Model;
using SquirrelFramework.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentmanagement
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var somebody = new User();
            Console.WriteLine("请输入班级学号");
            somebody.ClassId = int.Parse(Console.ReadLine());
            Console.WriteLine("请输入班级");
            somebody.ClassName = Console.ReadLine();
            Console.WriteLine("请输入姓名");
            somebody.Name = Console.ReadLine();
            Console.WriteLine("请输入积分");
            somebody.Gredits = int.Parse(Console.ReadLine());
            Console.WriteLine("请输入性别");
            somebody.Gender = bool.Parse(Console.ReadLine());
            Console.WriteLine("请输入leader");
            somebody.ReportTo = Console.ReadLine();
            Console.WriteLine("请输入Guthub帐号");
            somebody.Github = Console.ReadLine();
            var dbop = new DatabaseOperation();
            dbop.Add(somebody);
            Console.ReadKey();
        }
    }
    public class DatabaseOperation : RepositoryBase<User>
    {
    }
    [Collection("User")]
    public class User : DomainModel
    {
        public int ClassId { get; set; }
        public string ClassName { get; set; }
        public string Name { get; set; }
        public int Gredits { get; set; }
        public bool Gender { get; set; }
        public string ReportTo { get; set; }
        public string Github { get; set; }

    }
}
