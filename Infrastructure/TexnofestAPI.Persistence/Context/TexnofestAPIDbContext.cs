using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TexnofestAPI.Domain.Entities;
namespace TexnofestAPI.Persistence.Context
{
    public class TexnofestAPIDbContext:DbContext
    {
        public TexnofestAPIDbContext(DbContextOptions<TexnofestAPIDbContext> options) : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }   
        public DbSet<User> Users { get; set; }
        public DbSet<ProductUser> ProductUsers { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductUser>()
       .HasKey(bc => new { bc.ProductId, bc.UserId });
            modelBuilder.Entity<ProductUser>()
                .HasOne(bc => bc.Product)
                .WithMany(b => b.ProductUsers)
                .HasForeignKey(bc => bc.ProductId);
            modelBuilder.Entity<ProductUser>()
                .HasOne(bc => bc.User)
                .WithMany(c => c.ProductUsers)
                .HasForeignKey(bc => bc.UserId);
        }

    }
}
