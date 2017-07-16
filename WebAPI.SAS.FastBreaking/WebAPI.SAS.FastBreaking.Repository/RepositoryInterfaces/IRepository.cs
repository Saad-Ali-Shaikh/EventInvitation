using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace WebAPI.SAS.FastBreaking.Repository.RepositoryInterfaces
{
    public interface IRepository<TModel>
    {
        Task<IEnumerable<TModel>> GetAsync(
            Expression<Func<TModel,bool>> filter = null,
            Func<IQueryable<TModel>,IOrderedQueryable<TModel>> orderby = null, 
            string includeProperties = "");
        Task InsertAsync(TModel entity);
        Task UpdateAsync(TModel entity);
        void DeleteAsync(object id);

    }
}
