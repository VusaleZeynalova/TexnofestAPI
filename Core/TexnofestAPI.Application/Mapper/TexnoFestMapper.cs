using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TexnofestAPI.Application.Features.Commands.Users;
using TexnofestAPI.Application.Features.Commands.Users.Login;
using TexnofestAPI.Domain.Entities;

namespace TexnofestAPI.Application.Mapper
{
    public class TexnoFestMapper:Profile
    {
        public TexnoFestMapper()
        {
            CreateMap<UserRegisterCommandRequest, User>().ReverseMap();
            CreateMap<UserLoginCommandRequest, User>().ReverseMap();
        }
    }
}
