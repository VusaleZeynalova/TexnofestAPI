using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TexnofestAPI.Domain.Entities;

namespace TexnofestAPI.Application.Repositories.Users
{
    public interface IUserReadRepository:IReadRepository<User>
    {
        Task<User> GetByGuid(string userCode);
        List<User> GetAllWitnInclude();
    }
}
