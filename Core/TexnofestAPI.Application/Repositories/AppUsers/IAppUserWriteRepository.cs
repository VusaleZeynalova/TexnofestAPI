using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TexnofestAPI.Domain.Entities.Identity;

namespace TexnofestAPI.Application.Repositories.AppUsers
{
    public interface IAppUserWriteRepository : IWriteRepository<AspNetUser>
    {

    }
}
