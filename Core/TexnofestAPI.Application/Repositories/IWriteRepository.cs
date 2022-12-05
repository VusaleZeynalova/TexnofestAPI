using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TexnofestAPI.Domain.Entities.Common;

namespace TexnofestAPI.Application.Repositories
{
    public interface IWriteRepository<T> : IRepository<T> where T : BaseEntity
    {
        Task AddAsync(T entity);  
        void Update(T entity);
        Task DeleteAsync(int id);
        Task SaveAsync();

        

    }
}
