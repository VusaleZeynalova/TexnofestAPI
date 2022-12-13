using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using TexnofestAPI.Domain.Entities.Identity;
using TexnofestAPI.Persistence.Context;

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
            services.AddIdentity<AspNetUser, AppRole>(options =>
            {
                options.Password.RequiredLength = 3;
                options.Password.RequireDigit = false;
                options.Password.RequireLowercase = false;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireLowercase = false;
                options.Password.RequireUppercase = false;
            }).AddEntityFrameworkStores<TexnofestAPIDbContext>();
        }
    }
}
