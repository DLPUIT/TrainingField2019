using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement
{
    using SquirrelFramework.Repository;
    using SquirrelFramework.Domain.Model;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var somebody = new User();

            Console.WriteLine("请输入班级ID");
            somebody.ClassId = Console.ReadLine();
            //Console.WriteLine("请输入班级ID");
            //somebody.ClassName = Console.ReadLine();
            //Console.WriteLine("请输入班级ID");
            //somebody.Name = Console.ReadLine();
            //somebody.Credits = int.Parse(Console.ReadLine());
            //somebody.Gender = bool.Parse(Console.ReadLine());
            //somebody.ReportTo = Console.ReadLine();
            //somebody.GitHub = Console.ReadLine();

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
        public string ClassId { get; set; }
        public string ClassName { get; set; }
        public string Name { get; set; }
        public int Credits { get; set; }
        public bool Gender { get; set; }
        public string ReportTo { get; set; }
        public string GitHub { get; set; }
    }
}
