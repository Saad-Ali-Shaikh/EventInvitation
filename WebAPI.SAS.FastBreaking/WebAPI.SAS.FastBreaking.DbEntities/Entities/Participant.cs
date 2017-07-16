using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPI.SAS.FastBreaking.DbEntities.Entities
{
    public class Participant : BaseEntity
    {
        public Participant()
        {
            this.Events = new HashSet<GatheringEvent>();
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NickName { get; set; }
        public string AddressLineOne { get; set; }
        public string HouseNumber { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string City { get; set; }
        public string Email { get; set; }
        public string ContactPhoneNumber { get; set; }

        public virtual ICollection<GatheringEvent> Events { get; set; }
    }
}
