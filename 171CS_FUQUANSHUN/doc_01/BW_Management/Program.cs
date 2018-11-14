using SquirrelFramework.Domain.Model;
using SquirrelFramework.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BW_Management
{
    using SquirrelFramework.Repository;                         
    using SquirrelFramework.Domain.Model;
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");           
            var somebody = new User();                         
            Console.WriteLine("请输入班级ID：");
            somebody.ClassId = Console.ReadLine();              
            Console.WriteLine("班级：");
            somebody.ClassName = Console.ReadLine();
            Console.WriteLine("姓名：");
            somebody.Name = Console.ReadLine();
            Console.WriteLine("得分：");
            somebody.Credits = int.Parse(Console.ReadLine());   
            Console.WriteLine("性别：");
            somebody.Gender = bool.Parse(Console.ReadLine());
            Console.WriteLine("汇报人：");
            somebody.ReportTo = Console.ReadLine();
            Console.WriteLine("GitHub账户：");
            somebody.GitHub = Console.ReadLine();
            var dbop = new DatabaseOperation();
            dbop.Add(somebody);                                
            var allMenber = dbop.GetAll();                                 
            var desb = dbop.Delete("171");                      
            var upsb = dbop.Update("171");                         
            Console.ReadKey();
        }
    }

    public class DatabaseOperation : RepositoryBase<User>       // 提供增删改查方法
    {
    }
    [Collection("BlackWhite")]                                  // 设置数据库表名
    public class User : DomainModel                             // 自定义类的继承，不过继承了什么？？？单击按F12
    {
        public string ClassId { get; set; }                     // 注意分号
        public string ClassName { get; set; }
        public string Name { get; set; }
        public int Credits { get; set; }
        public bool Gender { get; set; }
        public string ReportTo { get; set; }
        public string GitHub { get; set; }
    }











}
