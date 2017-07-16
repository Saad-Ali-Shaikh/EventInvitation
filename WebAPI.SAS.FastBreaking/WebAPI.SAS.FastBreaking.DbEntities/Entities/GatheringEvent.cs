using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPI.SAS.FastBreaking.DbEntities.Entities
{
    public class GatheringEvent : BaseEntity
    {
        public GatheringEvent()
        {
           this.Participants = new HashSet<Participant>();
        }

        public string EventName { get; set; }
        public string EventDescription { get; set; }
        public string Venue { get; set; }
        public DateTime EventStart { get; set; }
        public DateTime EventEnd { get; set; }
        public string EventAddress { get; set; }
        public string EventHouseNumber { get; set; }
        public string EventState { get; set; }
        public string EventZip { get; set; }
        public string EventCity { get; set; }

        public virtual ICollection<Participant> Participants { get; set; } 
    }
}
