using SquirrelFramework.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MANAGE
{
    class Program
    {
        
            static void Main(string[] args)
            {
                Console.WriteLine("hello world");
                var somebody = new User();
                Console.WriteLine("input classid");
                somebody.ClassId = Console.ReadLine();
                Console.WriteLine("input classname");
                somebody.ClassName = Console.ReadLine();
                somebody.Name = Console.ReadLine();
                somebody.Credits = int.Parse(Console.ReadLine());
            somebody.Gender = bool.Parse(Console.ReadLine());
            }
            public class User : DomainModel
            {
                public string ClassId { get; set; }
                public string ClassName { get; set; }
                public string Name { get; set; }
                public string ReportTo { get; set; }
                public string GitHub { get; set; }
                public int Credits { get; set; }
                public bool Gender { get; set; }
            }

        }
    
}
