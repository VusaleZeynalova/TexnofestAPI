using AutoMapper;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TexnofestAPI.Domain.Entities;
using TexnofestAPI.Domain.Entities.Identity;

namespace TexnofestAPI.Application.Features.Commands.AppUsers
{
    public class CreateAppUserHandler
    {
        readonly UserManager<TexnofestAPI.Domain.Entities.Identity.AspNetUser> _userManager;
        readonly IMapper _mapper;
        public CreateAppUserHandler(UserManager<TexnofestAPI.Domain.Entities.Identity.AspNetUser> userManager, IMapper mapper)
        {
            _userManager = userManager;
            _mapper = mapper;
        }

        public async Task<CreateAppUserCommandResponse> CreateAppUser(CreateAppUserCommandRequest request)
        {
            AspNetUser appUser = _mapper.Map<AspNetUser>(request);
            try
            {
                IdentityResult result = await _userManager.CreateAsync(appUser);
                
                return new()
                {
                    Succeeded = true,
                    Message = "Succesfully"
                };
            }
            catch(Exception ex)
            {
                return new()
                {
                    Succeeded=false,
                    Message="Try again"
                };
            }
            
        }
    }
}
