using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TexnofestAPI.Domain.Entities;
using TexnofestAPI.Domain.Entities.Identity;
namespace TexnofestAPI.Persistence.Context
{
    public class TexnofestAPIDbContext:IdentityDbContext<AspNetUser,AppRole,string>
    {
        public TexnofestAPIDbContext(DbContextOptions<TexnofestAPIDbContext> options) : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }   
    }
}
