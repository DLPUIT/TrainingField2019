using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SquirrelFramework.Domain.Model;

namespace WebApplication1.新文件夹2
{
    public class Class:DomainModel
    {
       public string OrganizerId { get; set; }
        public string OrganizerDisplayName { get; set; }
        public string TimeRange { get; set; }
        public string Topic { get; set; }
        public string Discription { get; set; }
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
