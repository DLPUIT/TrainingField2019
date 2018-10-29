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
            Console.WriteLine("请输入班级ID");
            student.ClassId = int.Parse(Console.ReadLine());
            Console.WriteLine("请输入班级名字");
            student.ClassName = int.Parse(Console.ReadLine());
            Console.WriteLine("请输入学号");
            student.StudentId = int.Parse(Console.ReadLine());
            Console.WriteLine("请输入名字");
            student.Name = int.Parse(Console.ReadLine());
            Console.WriteLine("请输入性别");
            student.Gender = int.Parse(Console.ReadLine());
            var db = new DatabaseOperation();
            db.Add(student);
            Console.ReadKey();

        }
    }
    public class DatabaseOperation : RepositoryBase<Student>
    {
    }
    [Collection("Student")]
    public class Student : DomainModel
    {
        public int ClassId { get; set; }
        public int ClassName { get; set; }

        public int StudentId { get; set; }
        public int Name { get; set; }
        public int Gender { get; set; }

    }
}
