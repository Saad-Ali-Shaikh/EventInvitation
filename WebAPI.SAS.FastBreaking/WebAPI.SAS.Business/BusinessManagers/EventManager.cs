using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPI.SAS.FastBreaking.Models.Models;
using WebAPI.SAS.FastBreaking.Repository.RepositoryInterfaces;

namespace WebAPI.SAS.Business.BusinessManagers
{
    public class EventManager : BaseManager<IRepository<EventMdl>>, IEventManager
    {

        public EventManager(IRepository<EventMdl> Repository): base(Repository)
        {
            
        }

        public async Task<IEnumerable<EventMdl>> GetEvents()
        {
            var e = await Repository.GetAsync();
            return e;
        }
    }
}
