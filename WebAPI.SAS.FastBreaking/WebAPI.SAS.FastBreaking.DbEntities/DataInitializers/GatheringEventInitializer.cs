using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPI.SAS.FastBreaking.DbEntities.DataContext;
using WebAPI.SAS.FastBreaking.DbEntities.Entities;

namespace WebAPI.SAS.FastBreaking.DbEntities.DataInitializers
{
    public class GatheringEventInitializer : DropCreateDatabaseIfModelChanges<EventContext>
    {
        protected override void Seed(EventContext context)
        {
            //base.Seed(context);

            var members1 = new List<Participant>
            {
                new Participant{AddressLineOne="Test Address 1",City="Test City",ContactPhoneNumber="123-777-7656",CreatedBy=1,CreatedOn= DateTime.Now,Email="test@gmail.com",FirstName="Test",HouseNumber="1234",LastName="Test LastName",ModifiedBy= 1,ModifiedOn= DateTime.Now,NickName="Test Nick",State="CT",Zip="17112"}
            };
            var members2 = new List<Participant>
            {
                new Participant{AddressLineOne="Test Address 2",City="Test City",ContactPhoneNumber="123-777-7656",CreatedBy=1,CreatedOn=DateTime.Now,Email="test@gmail.com",FirstName="Test",HouseNumber="1234",LastName="Test LastName",ModifiedBy= 1,ModifiedOn= DateTime.Now,NickName="Test Nick",State="CT",Zip="17112"}
            };

            var plEvent = new List<GatheringEvent>
            {
                new GatheringEvent{CreatedBy=1,CreatedOn= DateTime.Now,EventAddress= "Main Street",EventCity="Maryland Heights",EventStart= DateTime.Now,EventEnd= DateTime.Now,EventDescription="Test",EventName="Test Event 1",EventState="MO",EventZip="63043",ModifiedBy= 1,ModifiedOn= DateTime.Now,Participants= members1},
                new GatheringEvent{CreatedBy=1,CreatedOn=DateTime.Now,EventAddress="Main Street",EventCity="Maryland Heights",EventStart=DateTime.Now,EventEnd=DateTime.Now,EventDescription="Test",EventName="Test Event 2",EventState="MO",EventZip="63043",ModifiedBy=1,ModifiedOn=DateTime.Now,Participants= members2},
            };

            plEvent.ForEach(x => context.Events.Add(x));
            context.SaveChanges();

        }
    }
}
