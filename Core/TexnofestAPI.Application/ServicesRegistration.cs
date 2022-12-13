using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TexnofestAPI.Application.Features.Commands.AppUsers;
using TexnofestAPI.Application.Mapper;
using TexnofestAPI.Domain.Entities.Identity;

namespace TexnofestAPI.Application
{
    public static class ServicesRegistration
    {
        public static void AddApplicationRegistration(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(TexnoFestMapper));
            services.AddScoped<CreateAppUserHandler>();

        }
    }
}
