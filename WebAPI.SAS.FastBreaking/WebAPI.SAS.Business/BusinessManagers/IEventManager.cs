using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPI.SAS.FastBreaking.Models.Models;

namespace WebAPI.SAS.Business.BusinessManagers
{
    public interface IEventManager
    {
        Task<IEnumerable<EventMdl>> GetEvents();
    }
}
