using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPI.SAS.Business.BusinessManagers
{
    public class BaseManager<T> where T : class
    {
        protected T Repository; 
        public BaseManager(T Repository)
        {
            this.Repository = Repository;
        }
    }
}
