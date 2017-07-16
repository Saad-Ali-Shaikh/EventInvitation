using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPI.SAS.FastBreaking.Models.Models;
using WebAPI.SAS.FastBreaking.Repository.RepositoryInterfaces;

namespace WebAPI.SAS.Business.BusinessManagers
{
    public class ParticipantManager : BaseManager<IRepository<ParticipantMdl>>, IParticipantManager
    {
        public ParticipantManager(IRepository<ParticipantMdl> repository)
            : base(repository)
        {

        }



        public async Task<IEnumerable<ParticipantMdl>> GetParticipants()
        {
            var t = await Repository.GetAsync();
            return t;
        }
    }
}
