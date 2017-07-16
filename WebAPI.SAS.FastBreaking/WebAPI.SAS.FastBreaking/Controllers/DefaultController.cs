using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI.SAS.FastBreaking.DbEntities.DataContext;

namespace WebAPI.SAS.FastBreaking.Controllers
{
    public class DefaultController : ApiController
    {
        public IHttpActionResult Get()
        {
            var context = new EventContext();
            return Ok(context.Events.ToList());
        }
    }
}
