using AutoMapper;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using TexnofestAPI.Domain.Entities;

namespace TexnofestAPI.Application.Features.Commands.Users.Login
{
    public class UserLoginCommandHandler
    {
        private readonly IMapper _mapper;
        private readonly IConfiguration _configuration;
        public UserLoginCommandHandler(IMapper mapper, IConfiguration configuration)
        {
            _mapper = mapper;
            _configuration = configuration;

        }

        public async Task<UserLoginCommandResponse> Login(UserLoginCommandRequest request)
        {
            User user = _mapper.Map<User>(request);

            if ((user.Email != request.Email) && (!VerifyPasswordHash(request.Password, user.PasswordHash, user.PasswordSalt)))
            {
                return new()
                {
                    Success = false,
                    Message = "Email or password is incorrect"

                };
            }
            return new()
            {
                Success = true,
                Message = CreateToken(user)
            };

        }

        private bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt)//sonradan use-çinin daxil etdiyi parolanı yoxlayır
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512(passwordSalt))
            {
                var computedHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
                for (int i = 0; i < computedHash.Length; i++)
                {
                    if (computedHash[i] != passwordHash[i])
                    {
                        return false;
                    }
                }
            }
            return true;
        }


        //create token
        private string CreateToken(User user)
        {
            var claims = new List<Claim>()
            {
                new Claim(ClaimTypes.Name,user.Email)
            };
            var key = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes(_configuration.GetSection("TokenOptions:SecurityKey").Value));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256Signature);
            var token = new JwtSecurityToken(
                claims: claims,
                expires: DateTime.Now.AddDays(1),
                signingCredentials: creds
                );
            var jwt = new JwtSecurityTokenHandler().WriteToken(token);
            return jwt;
        }
    }
}
