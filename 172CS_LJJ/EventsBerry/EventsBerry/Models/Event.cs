using SquirrelFramework.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventsBerry.Models
{
    public class Event : DomainModel
    {
        public string OrganizerId { get; set; }
        public string OrganizerDisplayName { get; set; }
        public string TimeRange { get; set; }
        public string Topic { get; set; }
        public string Description { get; set; }
        public DateTime CreatedTime { get; set; }
        public List<CheckIn> CheckInList { get; set; }
    }
    public class CheckIn
    {
        public string ParticipaterId { get; set; }
        public string ParticipaterDisplayName { get; set; }
        public DateTime CheckInTime { get; set; }
    }
}
