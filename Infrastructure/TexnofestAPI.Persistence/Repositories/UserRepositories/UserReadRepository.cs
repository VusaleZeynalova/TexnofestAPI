using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TexnofestAPI.Application.Repositories.Users;
using TexnofestAPI.Domain.Entities;
using TexnofestAPI.Persistence.Context;

namespace TexnofestAPI.Persistence.Repositories.UserRepositories
{
    public class UserReadRepository : ReadRepository<User>, IUserReadRepository
    {
        private readonly TexnofestAPIDbContext dbContext;
        public UserReadRepository(TexnofestAPIDbContext context) : base(context)
        {
            dbContext = context;
        }

        public List<User> GetAllWitnInclude()
        {
            return dbContext.Users.Include(p => p.ProductUsers).ThenInclude(u=>u.Product).ToList();
        }

        public async Task<User> GetByGuid(string userCode)
        {
            return await dbContext.Users.FirstOrDefaultAsync(p => p.UserDescription == Guid.Parse(userCode));
        }
    }
}
