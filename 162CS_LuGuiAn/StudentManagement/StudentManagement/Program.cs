using SquirrelFramework.Domain.Model;
using SquirrelFramework.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            var student = new Student();
            Console.WriteLine("请输入班级号：");
            student.ClassId = int.Parse(Console.ReadLine());
            Console.WriteLine("请输入班级名字：");
            student.ClassName = Console.ReadLine();
            Console.WriteLine("请输入学号：");
            student.StudentId = int.Parse(Console.ReadLine());
            Console.WriteLine("请输入姓名：");
            student.Name = Console.ReadLine();
            Console.WriteLine("请输入性别：");
            student.Gender = Console.ReadLine();
            var db = new DatabaseOperation();
            db.Add(student);
            Console.ReadKey();
        }
    }
    public class DatabaseOperation : RepositoryBase<Student>
    {

    }
    [Collection("Student")]
    public class Student : DomainModel {
        public int ClassId { get; set; }
        public string ClassName { get; set; }

        public int StudentId { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }

    }
}
