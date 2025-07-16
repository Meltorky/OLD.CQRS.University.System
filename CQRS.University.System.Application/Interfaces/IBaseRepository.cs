using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CQRS.University.System.Domain.Common;
using CQRS.University.System.Domain.Constants;
using Microsoft.EntityFrameworkCore.Query;

namespace CQRS.University.System.Application.Interfaces
{
    public interface IBaseRepository<T> where T : class
    {
        Task<T?> GetById(
            int Id ,
            CancellationToken token, 
            List<Func<IQueryable<T>, IIncludableQueryable<T, object>>>? IncludeExpressions);

        Task<List<T>> Filter(CancellationToken token, QueryFilterModel<T> filterModel);

        Task<List<T>> GetAll(CancellationToken token);

        Task<bool> Add(T entity ,CancellationToken token);

        Task<bool> Update(T entity , CancellationToken token);

        Task<bool> Delete(T entity, CancellationToken token);
    }
}
