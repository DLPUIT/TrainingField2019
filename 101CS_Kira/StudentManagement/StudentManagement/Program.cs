using SquirrelFramework.Domain.Model;
using SquirrelFramework.Repository;
using SquirrelFramework.Utility;
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
            var someone = new User();
            Console.WriteLine("Please input ClassId:");
            someone.ClassId = Console.ReadLine();
            Console.WriteLine("Please input ClassName:");
            someone.ClassName = Console.ReadLine();
            Console.WriteLine("Please input Name:");
            someone.Name = Console.ReadLine();
            Console.WriteLine("Please input Creadits:");
            someone.Creadits = int.Parse(Console.ReadLine());
            Console.WriteLine("Please input Gender:");
            someone.Gender = bool.Parse(Console.ReadLine());
            Console.WriteLine("Please input ReportTo:");
            someone.ReportTo = Console.ReadLine();
            Console.WriteLine("Please input GitHubId:");
            someone.GitHubId = Console.ReadLine();
            
            var dbop = new Database();
            dbop.Add(someone);
            Console.ReadKey();

        }
    }

    public class Database: RepositoryBase<User>
    {
    }

    [Collection("User")]
    public class User: DomainModel
    {
        public string ClassId { get; set; }
        public string ClassName{ get; set; }
        public string Name { get; set; }
        public int Creadits { get; set; }
        public bool Gender { get; set; }
        public string ReportTo { get; set; }
        public string GitHubId { get; set; }
    }
}
