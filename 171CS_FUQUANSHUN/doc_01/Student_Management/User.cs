using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Management
{
    using SquirrelFramework.Domain.Model;

    [Collection("User")]

    public class User
    {
        public string ClassId { get; set; }
        public string Name { get; set; }
        public string Credit { get; set; }
        public string GitHub { get; set; }
    }
}
