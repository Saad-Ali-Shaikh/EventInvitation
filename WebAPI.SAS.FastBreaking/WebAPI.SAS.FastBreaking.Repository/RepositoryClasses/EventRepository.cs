using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using WebAPI.SAS.FastBreaking.DbEntities.DataContext;
using WebAPI.SAS.FastBreaking.DbEntities.Entities;
using WebAPI.SAS.FastBreaking.Models.Models;
using WebAPI.SAS.FastBreaking.Repository.RepositoryInterfaces;

namespace WebAPI.SAS.FastBreaking.Repository.RepositoryClasses
{
    public class EventRepository : IRepository<EventMdl>
    {
        private EventContext context = null;

        public EventRepository()
        {
            context = new EventContext();
        }

        public static Expression<Func<GatheringEvent, EventMdl>> EventMdlExpression = e => new EventMdl
        {
            EventId =  e.Id,
            EventAddress = e.EventAddress,
            EventCity = e.EventCity,
            EventDescription = e.EventDescription,
            EventEnd = e.EventEnd,
            EventStart = e.EventStart,
            EventHouseNumber = e.EventHouseNumber,
            EventName = e.EventName,
            EventState = e.EventState,
            EventZip = e.EventZip
        };


        public async Task<IEnumerable<EventMdl>> GetAsync(System.Linq.Expressions.Expression<Func<EventMdl, bool>> filter = null, Func<IQueryable<EventMdl>, IOrderedQueryable<EventMdl>> orderby = null, string includeProperties = "")
        {
            IQueryable<EventMdl> query = null;
            query = context.Events.Select(EventMdlExpression);
            if (filter != null)
            {
                query = query.Where(filter);
            }
            if (orderby != null)
            {
                return await orderby(query).ToListAsync();
            }
            else
            {
                return await query.ToListAsync();
            }
        }

        public Task InsertAsync(EventMdl entity)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(EventMdl entity)
        {
            throw new NotImplementedException();
        }

        public void DeleteAsync(object id)
        {
            throw new NotImplementedException();
        }
    }
}
