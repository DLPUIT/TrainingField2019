using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DlpuManager.Service
{
    using SquirrelFramework.Domain.Model;

    [Collection("User2")]
    public class User : DomainModel
    {
        public string ClassId { get; set; }
        public string Name { get; set; }
        public int Credits { get; set; }
        public string GitHub { get; set; }
    }
}
