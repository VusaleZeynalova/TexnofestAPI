using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TexnofestAPI.Application.Features.Commands.Products;
using TexnofestAPI.Application.Features.Commands.Users.Login;
using TexnofestAPI.Application.Features.Commands.Users.Register;
using TexnofestAPI.Application.Features.Queries.Users.GetAllUser;
using TexnofestAPI.Domain.Entities;

namespace TexnofestAPI.Application.Mapper
{
    public class TexnoFestMapper:Profile
    {
        public TexnoFestMapper()
        {
            CreateMap<UserRegisterCommandRequest, User>().ReverseMap();
            CreateMap<UserLoginCommandRequest, User>().ReverseMap();
            CreateMap<GetAllQueryRequest,User>().ReverseMap();
            CreateMap<ProductUsersRequest, ProductUser>().ReverseMap();
            CreateMap<ProductQueryRequest, Product>().ReverseMap();
        }
    }
}
