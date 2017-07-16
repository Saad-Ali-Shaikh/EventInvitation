using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StructureMap;
using WebAPI.SAS.FastBreaking.Repository.DependencyResolution;
using StructureMap.Configuration.DSL;
using StructureMap.Graph;

namespace WebAPI.SAS.Business.DependencyResolution
{
    public class BusinessRegistry : Registry
    {
        public BusinessRegistry()
        {
            Scan(scan =>
            {
                scan.TheCallingAssembly();
                scan.WithDefaultConventions();
            });

            IncludeRegistry<RepositoryRegistry>();
        }
    }
}
