using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace userinformation
{
    using SquirrelFramework.Repository;
    using SquirrelFramework.Domain.Model;
    class Program
    {
        static void Main(string[] args)
        {
            var somebody = new user();
            Console.WriteLine("请输入专业班级：");
            somebody.majorclass = Console.ReadLine();
            //Console.WriteLine("请输入班级学号：");
            //somebody.classname = Console.ReadLine();
            //Console.WriteLine("请输入姓名：");
            //somebody.name = Console.ReadLine();
            //Console.WriteLine("请输入积分：");
            //somebody.credits = int.Parse(Console.ReadLine());
            //Console.WriteLine("请输入性别：");
            //somebody.gender = bool.Parse(Console.ReadLine()) ;
            //Console.WriteLine("请输入lead：");
            //somebody.reportto = Console.ReadLine();

            var dbop = new DatabassOperation();
            dbop.Add(somebody);

            Console.ReadKey();
        }
    }
    public class DatabassOperation : RepositoryBase<user>
    {

    }
    [Collection("user")]
    public class user : DomainModel
    {
        public string majorclass { get; set; }
        public string classnumber { get; set; }
        public string name { get; set; }
        public string credits { get; set; }
        public string gender { get; set; }
        public string reportto { get; set; }
        public string github { get; set; }
    }
}
