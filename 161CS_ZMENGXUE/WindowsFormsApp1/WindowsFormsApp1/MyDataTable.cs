using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    using SquirrelFramework.Domain.Model;
    class MyDataTable: DomainModel
    {
        public string Id { get; set; }
        public string TypeName { get; set; }
    }
}
