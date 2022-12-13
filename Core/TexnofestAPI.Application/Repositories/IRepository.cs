using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TexnofestAPI.Domain.Entities.Common;

namespace TexnofestAPI.Application.Repositories
{
    public interface IRepository<T> where T : class
    {
        DbSet<T> Table { get; }
    }
}
