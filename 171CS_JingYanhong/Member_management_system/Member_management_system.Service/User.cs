using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Member_management_system
{
    using SquirrelFramework.Domain.Model;
    [Collection("User")]//User 数据库中表


    public class User : DomainModel
    {
        public string ClassId { get; set; }
        public string ClassName { get; set; }
        public string Name { get; set; }
        public int Credits { get; set; }
        public string Reportto { get; set; }
        public string GitHub { get; set; }
    }

}
