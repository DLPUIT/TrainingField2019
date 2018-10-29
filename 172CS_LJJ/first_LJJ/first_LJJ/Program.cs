
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace first_LJJ
{
    using SquirrelFramework.Domain.Model;
    using SquirrelFramework.Repository;
    class Program
    {
        static void Main(string[] args)
        {
            var somebody = new User();
            Console.WriteLine("请输入班级ID");
            somebody.ClassId = Console.ReadLine();
            Console.WriteLine("请输入班级名称");
            somebody.ClassName = Console.ReadLine();
            Console.WriteLine("请输入姓名");
            somebody.Name = Console.ReadLine();
            Console.WriteLine("请输入当前积分");
            somebody.Credits = int.Parse(Console.ReadLine());
            Console.WriteLine("请输入性别");
            somebody.Gender = Console.ReadLine();
            Console.WriteLine("请输入领导");
            somebody.ReportTo = Console.ReadLine();
            Console.WriteLine("请输入GitHub账户");
            somebody.GitHub = Console.ReadLine();
            var db = new Database();
            db.Add(somebody);
            Console.ReadKey();
        }
    }

    public class Database : RepositoryBase<User>
    {
    }

    [Collection("User")]
    public class User : DomainModel
    {
        public string ClassId { get; set; }
        public string ClassName { get; set; }
        public string Name { get; set; }
        public int Credits { get; set; }
        public string Gender { get; set; }
        public string ReportTo { get; set; }
        public string GitHub { get; set; }
    }
}
