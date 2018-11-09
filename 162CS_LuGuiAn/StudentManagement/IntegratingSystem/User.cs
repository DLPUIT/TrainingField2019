using SquirrelFramework.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegratingSystem
{
    public class User : DomainModel
    {
        public User(string classId, string className, string name, int credits, bool gender, string reportTo, string gitHub)
        {
            ClassId = classId;
            ClassName = className;
            Name = name;
            Credits = credits;
            Gender = gender;
            ReportTo = reportTo;
            GitHub = gitHub;
        }

        public string ClassId { get; set; }
        public string ClassName { get; set; }
        public string Name { get; set; }
        public int Credits { get; set; }
        public bool Gender { get; set; }
        public string ReportTo { get; set; }
        public string GitHub { get; set; }
      
    }
}
