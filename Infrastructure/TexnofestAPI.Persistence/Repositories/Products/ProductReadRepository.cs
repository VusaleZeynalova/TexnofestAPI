using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TexnofestAPI.Application.Repositories.Products;
using TexnofestAPI.Domain.Entities;
using TexnofestAPI.Persistence.Context;

namespace TexnofestAPI.Persistence.Repositories.Products
{
    public class ProductReadRepository : ReadRepository<Product>, IProductReadRepository
    {
        private readonly TexnofestAPIDbContext _context;
        public ProductReadRepository(TexnofestAPIDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<Product> GetByName(string productName)
        {
            return await _context.Products.FirstOrDefaultAsync(p=>p.ProductName==productName);

        }
    }
}
