using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TexnofestAPI.Domain.Entities;

namespace TexnofestAPI.Application.Repositories.Products
{
    public interface IProductReadRepository:IReadRepository<Product>
    {
        Task<Product> GetByName(string productName);
    }
}
