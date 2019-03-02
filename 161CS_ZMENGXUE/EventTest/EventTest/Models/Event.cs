using SquirrelFramework.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventTest.Models
{
    public class Event:DomainModel
    {
        public string OrganizerID { get; set; }
        public string OrganizerDisplayName { get; set; }
        public string TimeRange{ get; set; }
        public string Topic{ get; set; }
        public string Description { get; set; }
        public DateTime CreatedTime{ get; set; }
        public string CheckInList{ get; set; }

  
    }
    public class CheckIn
    {
        public string AccepterID { get; set; }

        public string AccepterDisplayName { get; set; }
    }
}
