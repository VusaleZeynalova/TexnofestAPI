using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TexnofestAPI.Application.Repositories;
using TexnofestAPI.Application.Repositories.Users;
using TexnofestAPI.Domain.Entities;
using TexnofestAPI.Persistence.Context;

namespace TexnofestAPI.Persistence.Repositories.UserRepositories
{
    public class UserWriteRepository : WriteRepository<User>, IUserWriteRepository
    {
        public UserWriteRepository(TexnofestAPIDbContext context) : base(context)
        {
        }
    }
}
