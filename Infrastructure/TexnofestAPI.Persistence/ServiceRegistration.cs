using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        }
    }
}
