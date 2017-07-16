using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Policy;
using System.Threading.Tasks;
using System.Web.Http;
using WebAPI.SAS.Business.BusinessManagers;
using WebAPI.SAS.FastBreaking.Extensions.ExtensionClasses;

namespace WebAPI.SAS.FastBreaking.Controllers
{
    public class ParticipantsController : ApiController
    {
        private IParticipantManager participantManager;

        public ParticipantsController(IParticipantManager participantManager)
        {
            this.participantManager = participantManager;
        }

        public async Task<IHttpActionResult> Get()
        {
            var result = await participantManager.GetParticipants();
            return Ok(result.TransformtoDto());
        }
    }
}
