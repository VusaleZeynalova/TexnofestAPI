using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TexnofestAPI.Application.Repositories;
using TexnofestAPI.Persistence.Context;

namespace TexnofestAPI.Persistence.Repositories
{
    public class ReadRepository<T> : IReadRepository<T> where T : class
    {
        private readonly TexnofestAPIDbContext _context;
        public ReadRepository(TexnofestAPIDbContext context)
        {
            _context = context;
        }
        public DbSet<T> Table => _context.Set<T>();

        public IQueryable<T> GetAll()
        {
            return Table;      
        }

        public async Task<T> GetByIdAsync(int id)
        {
            var result=await Table.FindAsync(id);
            return result;
        }

        public async Task<T> GetSingleAsync(Expression<Func<T, bool>> predicate)
        {
            return await Table.FirstOrDefaultAsync(predicate);
        }

        public IQueryable<T> GetWhere(Expression<Func<T, bool>> predicate)
        {
            return Table.Where(predicate);
        }
    }
}
