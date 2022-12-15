using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TexnofestAPI.Application.Repositories;

namespace TexnofestAPI.Persistence.Repositories
{
    public class ReadRepository<T> : IReadRepository<T> where T : class
    {
        public DbSet<T> Table => throw new NotImplementedException();

        public IQueryable<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<T> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<T> GetSingleAsync(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> GetWhere(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }
    }
}
