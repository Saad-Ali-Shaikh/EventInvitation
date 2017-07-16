using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPI.SAS.FastBreaking.DbEntities.Entities;
//https://www.codeproject.com/Articles/1056900/Through-ASP-NET-Web-API
namespace WebAPI.SAS.FastBreaking.DbEntities.DatabaseConfiguration
{
    public class EventConfig : EntityTypeConfiguration<GatheringEvent>
    {
        public EventConfig()
        {
            Property(y => y.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            HasKey(y => y.Id);

            HasMany(y => y.Participants).WithMany(y => y.Events)
                .Map(m =>
                {
                    m.ToTable("EventParticipant");
                    m.MapLeftKey("GatheringEventId");
                    m.MapRightKey("ParticipantId");
                });
        }
    }
}
