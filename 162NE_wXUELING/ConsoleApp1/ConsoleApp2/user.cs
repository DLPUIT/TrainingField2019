using SquirrelFramework.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    [Collection("user")]
    public class User:DomainModel
    {
        public string ClassId { get; set; }
        public string Name { get; set; }
        public int Credits { get; set; }
        public string Github { get; set; }
    }
}
