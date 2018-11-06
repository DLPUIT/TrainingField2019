using SquirrelFramework.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
   public  class UserModel:DomainModel
    {
        public string classId{ get; set; }
        public string className{ get; set; }
        public string name { get; set; }
        public int credits { get; set;}
        public string gender { get; set; }
        public string team { get; set; }
        public string github { get; set; }
    }
}
