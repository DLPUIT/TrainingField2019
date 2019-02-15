using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SquirrelFramework.Domain.Model;

namespace EventBerry.Models
{
    public class Event : DomainModel
    {
        public Event()
        {
            this.CheckInList = new List<CheckIn>();
        }

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
        public string ParticipatorId { get; set; }
        public string ParticipatorDisplayName { get; set; }
        public DateTime CheckInTime { get; set; }
    }
}
