using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using TexnofestAPI.Application.Abstractions.Services;
using TexnofestAPI.Infrastructure.Services;

namespace TexnofestAPI.Infrastructure
{
    public  static class ServiceRegistration
    {
        public static void AddInfrastructureRegistration(this IServiceCollection services)
        {
            services.AddScoped<IMailService, MailService>();
        }
    }
}
