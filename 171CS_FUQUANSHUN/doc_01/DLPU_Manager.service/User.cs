using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLPU_Manager
{
    using SquirrelFramework.Domain.Model;
    [Collection("BlackAndWhite")]

    public class User : DomainModel
    {
        public string ClassId { get; set; }
        public string Name { get; set; }
        public int Credit { get; set; }
        public string GitHub { get; set; }
    }
}


    

    


