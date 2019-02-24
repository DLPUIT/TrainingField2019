using SquirrelFramework.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppCore.MainClass
{
    public class Events : DomainModel
    {
        public string OrganzerID { get; set; }
        public string OrganzerDisplayName { get; set; }
        public string TimeRange { get; set; }
        public string Topic { get; set; }
        public string Description { get; set; }
        public DateTime CreatedTime { get; set; }
        public List<CheakIn> CheakInList { get; set; }
    }
    public class CheakIn    // 签到表
    {
        public string ParticipatorId { get; set; }
        public string ParticipatorDisplayName { get; set; }
        public DateTime CheckInTime { get; set; }
    }
}
