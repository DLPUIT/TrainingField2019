using SquirrelFramework.Domain.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    [Collection("WinFormUser")]
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
