using SquirrelFramework.Domain.Model;
using System;
using SquirrelFramework.Repository;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace text1
{

    class program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("hellow World!");

            var somebody = new User();
            Console.WriteLine("请输入班级ID：");
            somebody.ClassID = Console.ReadLine();
            Console.WriteLine("请输入班级名：");
            somebody.ClassName = Console.ReadLine();
            Console.WriteLine("请输入姓名：");
            somebody.Name = Console.ReadLine();
            Console.WriteLine("请输入积分：");
            somebody.Credits = int.Parse(Console.ReadLine());
            Console.WriteLine("请输入性别：");
            somebody.Gender = bool.Parse(Console.ReadLine());
            Console.WriteLine("请输入队长：");
            somebody.ReporTo = Console.ReadLine();
            Console.WriteLine("请输入GitHub账号：");
            somebody.GitHub = Console.ReadLine();

            var dbop = new DatabaseOperation();
            dbop.Add(somebody);

            // var allMember = dbop.GetAll();
            //var allMember = dbop.Delete();
            //var allMember = dbop.Update();


            Console.ReadKey();
        }
    }



    class DatabaseOperation : RepositoryBase<User>
    {

    }

    [Collection("User")]

    class User : DomainModel
    {
        public string ClassID { get; set; }
        public string ClassName { get; set; }
        public string Name { get; set; }
        public int Credits { get; set; }
        public bool Gender { get; set; }
        public string ReporTo { get; set; }
        public string GitHub { get; set; }
    }













    //public class program
    //{
    //    private static void Main(string[] args)
    //    {
    //        var somebody = new User();
    //        Console.WriteLine("请输入班级ID");
    //        somebody.ClassID = Console.ReadLine();
    //        Console.WriteLine("请输入班级名称");
    //        somebody.ClassName = Console.ReadLine();
    //        Console.WriteLine("请输入姓名");
    //        somebody.Name = Console.ReadLine();
    //        Console.WriteLine("请输入当前积分");
    //        somebody.Credits = Console.ReadLine();
    //        Console.WriteLine("请输入性别");
    //        somebody.Gender = Console.ReadLine();
    //        Console.WriteLine("请输入领导");
    //        somebody.ReportTo = Console.ReadLine();
    //        Console.WriteLine("请输入GitHub账户");
    //        somebody.GitHub = Console.ReadLine();

    //        var dbService = new DatabaseOperation();
    //            //dbService.Add(somebody);

    //        Console.ReadKey();


    //    }
    //    public void DatabaseOperation()
    //    {

    //    }

    //    [Collection("User")]
    //    public class User : DomainModel
    //    {
    //        public string ClassID { get; set; }
    //        public string ClassName { get; set; }
    //        public string Name { get; set; }
    //        public string Credits { get; set; }
    //        public string Gender { get; set; }
    //        public string ReportTo { get; set; }
    //        public string GitHub { get; set; }

    //    }

}



