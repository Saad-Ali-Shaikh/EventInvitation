using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPI.SAS.FastBreaking.DbEntities.Entities;

namespace WebAPI.SAS.FastBreaking.DbEntities.DatabaseConfiguration
{
    public class ParticipantConfig : EntityTypeConfiguration<Participant>
    {
        public ParticipantConfig()
        {
            Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            HasKey(x => x.Id);
        }
    }
}
