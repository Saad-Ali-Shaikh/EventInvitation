using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using WebAPI.SAS.Business.BusinessManagers;
using WebAPI.SAS.Dto.DTOObject;
using WebAPI.SAS.FastBreaking.Extensions.ExtensionClasses;

namespace WebAPI.SAS.FastBreaking.Controllers
{
    public class EventsController : ApiController
    {
        private IEventManager eventManager;

        public EventsController(IEventManager eventManager)
        {
            this.eventManager = eventManager;
        }

        /// <summary>
        /// Retrives list of all events
        /// </summary>
        /// <returns>EventDto</returns>
        [ResponseType(typeof(IEnumerable<EventDto>))]
        public async Task<IHttpActionResult> Get()
        {
            var result = await eventManager.GetEvents();
            return Ok(result.TransformtoDto());
        }

    }
}
