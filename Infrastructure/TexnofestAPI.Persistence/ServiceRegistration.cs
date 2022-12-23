using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using TexnofestAPI.Application.Repositories;
using TexnofestAPI.Application.Repositories.Products;
using TexnofestAPI.Application.Repositories.Users;
using TexnofestAPI.Persistence.Context;
using TexnofestAPI.Persistence.Repositories;
using TexnofestAPI.Persistence.Repositories.Products;
using TexnofestAPI.Persistence.Repositories.UserRepositories;

namespace TexnofestAPI.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceRegistration(this IServiceCollection services)
        {
            services.AddDbContext<TexnofestAPIDbContext>(options =>
            {
                options.UseSqlServer(Configuraton.ConnectionString);

            });

            services.AddScoped<IUserWriteRepository, UserWriteRepository>();
            services.AddScoped<IUserReadRepository, UserReadRepository>();

            services.AddScoped<IProductReadRepository, ProductReadRepository>();
           
        }
    }
}
