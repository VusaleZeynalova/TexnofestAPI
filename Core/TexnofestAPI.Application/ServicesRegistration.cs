using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TexnofestAPI.Application.Features.Commands.Users;
using TexnofestAPI.Application.Features.Commands.Users.Login;
using TexnofestAPI.Application.Mapper;

namespace TexnofestAPI.Application
{
    public static class ServicesRegistration
    {
        public static void AddApplicationRegistration(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(TexnoFestMapper));
            services.AddScoped<UserRegisterCommandHandler>();
            services.AddScoped<UserLoginCommandHandler>();
        }
    }
}
