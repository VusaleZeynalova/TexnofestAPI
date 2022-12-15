using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TexnofestAPI.Application.Repositories;
using TexnofestAPI.Persistence.Context;

namespace TexnofestAPI.Persistence.Repositories
{
    public class WriteRepository<T> : IWriteRepository<T> where T : class
    {
        private readonly TexnofestAPIDbContext _context;
        public WriteRepository(TexnofestAPIDbContext context)
        {
            _context = context;
        }
    
        public DbSet<T> Table =>_context.Set<T>();

        public async Task AddAsync(T entity)
        {
            await _context.AddAsync(entity);
        }

        public async Task DeleteAsync(int id)
        {
            T model = await Table.FindAsync(id);
             _context.Remove(model);
        }

        public async Task<int> SaveAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Update(T entity)
        {
            _context.Update(entity);
        }
    }

}
