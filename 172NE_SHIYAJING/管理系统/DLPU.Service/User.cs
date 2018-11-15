using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLPU.Service
{
    using SquirrelFramework.Domain.Model;
    [Collection("User")]
    public class User : DomainModel
    {
        public string ClassId { get; set; }
        public string ClassName { get; set; }
        public string Name { get; set; }
        public int Gredits { get; set; }
        public bool Gender { get; set; }
        public string ReportTo { get; set; }
        public string Github { get; set; }

    }
}
           
       

  

