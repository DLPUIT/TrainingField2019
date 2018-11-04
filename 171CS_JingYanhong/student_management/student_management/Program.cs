using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student_management
{
    using SquirrelFramework.Repository;
    using SquirrelFramework.Domain.Model;
    class Program
    {
        static void Main(string[] args)
        {
            var somebody = new student();
            Console.WriteLine("请输入姓名：");
            somebody.name = Console.ReadLine();
            Console.WriteLine("请输入班级：");
            somebody.classroom = Console.ReadLine();
            Console.WriteLine("请输入学号：");
            somebody.xh = Console.ReadLine();
           Console.WriteLine("请输入成绩：");
            somebody.grade = int.Parse(Console.ReadLine());
            Console.WriteLine("请输入性别：");
            somebody.gender = bool.Parse(Console.ReadLine());
            Console.WriteLine("请输入lead：");
            somebody.leader = Console.ReadLine();
            var dbop = new DatabassOperation();
            dbop.Add(somebody);
            Console.ReadKey();
        }
    }
    public class DatabassOperation : RepositoryBase<student>
    {

    }
    [Collection("student_message")]
    public class student : DomainModel
    {
        public string classroom { get; set; }
        public string xh { get; set; }
        public string name { get; set; }
        public int grade { get; set; }
        public bool gender { get; set; }
        public string leader { get; set; }
    }
}

