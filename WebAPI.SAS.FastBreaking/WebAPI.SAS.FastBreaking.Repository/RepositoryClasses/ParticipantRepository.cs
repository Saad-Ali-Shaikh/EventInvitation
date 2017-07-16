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
    public class ParticipantRepository : IRepository<ParticipantMdl>
    {
        private EventContext context = null;

        public ParticipantRepository()
        {
            context = new EventContext();
        }

        public static Expression<Func<Participant, ParticipantMdl>> ParticipantMdlExpression = p => new ParticipantMdl
        {
            ParticipantId = p.Id,
            FirstName = p.FirstName,
            LastName = p.LastName,
            NickName = p.NickName,
            Email = p.Email,
            ContactPhoneNumber = p.ContactPhoneNumber,
            HouseNumber = p.HouseNumber,
            AddressLineOne = p.AddressLineOne,
            City = p.City,
            State = p.State,
            Zip = p.Zip,
        };

        public async Task<IEnumerable<ParticipantMdl>> GetAsync(System.Linq.Expressions.Expression<Func<ParticipantMdl, bool>> filter = null, Func<IQueryable<ParticipantMdl>, IOrderedQueryable<ParticipantMdl>> orderby = null, string includeProperties = "")
        {
            IQueryable<ParticipantMdl> query;
            query = context.Participants.Select(ParticipantMdlExpression);
            /*query = context.Participants.Select(p => new ParticipantMdl
            {
                ParticipantId = p.Id,
                FirstName = p.FirstName,
                LastName = p.LastName,
                NickName = p.NickName,
                Email = p.Email,
                ContactPhoneNumber = p.ContactPhoneNumber,
                HouseNumber = p.HouseNumber,
                AddressLineOne = p.AddressLineOne,
                City = p.City,
                State = p.State,
                Zip = p.Zip,
            });*/
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

        public Task InsertAsync(ParticipantMdl entity)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(ParticipantMdl entity)
        {
            throw new NotImplementedException();
        }

        public void DeleteAsync(object id)
        {
            throw new NotImplementedException();
        }
    }
}
