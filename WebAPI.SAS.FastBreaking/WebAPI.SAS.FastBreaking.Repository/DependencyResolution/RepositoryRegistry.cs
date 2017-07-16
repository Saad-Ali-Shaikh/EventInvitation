using StructureMap;
using WebAPI.SAS.FastBreaking.Models.Models;
using WebAPI.SAS.FastBreaking.Repository.RepositoryClasses;
using WebAPI.SAS.FastBreaking.Repository.RepositoryInterfaces;
using StructureMap.Configuration.DSL;
using StructureMap.Graph;

namespace WebAPI.SAS.FastBreaking.Repository.DependencyResolution
{
    public class RepositoryRegistry: Registry
    {
        public RepositoryRegistry()
        {
            For<IRepository<EventMdl>>().Use<EventRepository>();
            For<IRepository<ParticipantMdl>>().Use<ParticipantRepository>();
        }
    }
}
