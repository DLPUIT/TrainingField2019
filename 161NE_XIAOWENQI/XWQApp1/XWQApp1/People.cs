using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XWQApp1
{
    class People
    {
        [Collection("User")]
        public class people : DomainModel
        {
            internal string name;

            public string ClassId { get; set; }
            public string ClassName { get; set; }
            public string Name { get; set; }
            public int Credits { get; set; }
            public bool Gender { get; set; }
            public string ReportTo { get; set; }
            public string GitHub { get; set; }

        }
    }
}
