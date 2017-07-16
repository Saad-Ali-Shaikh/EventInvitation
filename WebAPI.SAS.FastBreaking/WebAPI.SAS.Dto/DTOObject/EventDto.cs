using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPI.SAS.Dto.DTOObject
{
    public class EventDto
    {
        public int EventId { get; set; }

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
    }
}
