using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPI.SAS.FastBreaking.DbEntities.DatabaseConfiguration;
using WebAPI.SAS.FastBreaking.DbEntities.DataInitializers;
using WebAPI.SAS.FastBreaking.DbEntities.Entities;

namespace WebAPI.SAS.FastBreaking.DbEntities.DataContext
{
    public class EventContext : DbContext
    {
        public EventContext()
            : base("EventsConnection")
        {
            Database.SetInitializer(new GatheringEventInitializer());
        }

        public IDbSet<GatheringEvent> Events { get; set; }
        public IDbSet<Participant> Participants { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new ParticipantConfig());
            modelBuilder.Configurations.Add(new EventConfig());
        }
    }
}
