using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TexnofestAPI.Application.Features.Commands.AppUsers;
using TexnofestAPI.Domain.Entities.Identity;

namespace TexnofestAPI.Application.Mapper
{
    public class TexnoFestMapper:Profile
    {
        public TexnoFestMapper()
        {
            CreateMap<CreateAppUserCommandRequest, AspNetUser>();
        }
    }
}
