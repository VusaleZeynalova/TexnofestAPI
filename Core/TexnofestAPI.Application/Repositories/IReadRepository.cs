using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TexnofestAPI.Domain.Entities.Common;

namespace TexnofestAPI.Application.Repositories
{
    public interface IReadRepository<T>:IRepository<T> where T : class
    {
        IQueryable<T> GetAll();
        IQueryable<T> GetWhere(Expression<Func<T,bool>> predicate);
        Task<T> GetSingleAsync(Expression<Func<T,bool>> predicate);
        Task<T> GetByIdAsync(int id);
    }
}
