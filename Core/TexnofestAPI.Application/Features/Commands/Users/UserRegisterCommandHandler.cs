using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using TexnofestAPI.Application.Abstractions.Services;
using TexnofestAPI.Application.Repositories.Users;
using TexnofestAPI.Domain.Entities;

namespace TexnofestAPI.Application.Features.Commands.Users
{
    public class UserRegisterCommandHandler
    {
        private readonly IMapper _mapper;
        private readonly IUserWriteRepository _repository;
        private readonly IMailService _mailService;
        public UserRegisterCommandHandler(IMapper mapper, IUserWriteRepository repository,IMailService mailService)
        {
            _mapper = mapper;
            _repository = repository;
            _mailService = mailService;
        }
        public async Task<UserRegisterCommandResponse> RegisterUser(UserRegisterCommandRequest request)
        {
            try
            {
              CreatePasswordHash(request.Password, out byte[] passwordHash, out byte[] passwordSalt);

                User user = _mapper.Map<User>(request);
                user.PasswordHash = passwordHash;
                user.PasswordSalt = passwordSalt;
                user.UserDescription = Guid.NewGuid();
                await _repository.AddAsync(user);
                await _repository.SaveAsync();
                return new()
                {
                    Success = true,
                    Message = "Successfully"
                };
            }
            catch (Exception ex)
            {
                return new()
                {
                    Success = false,
                    Message = ex.Message
                };
            }


        }

        public static void CreatePasswordHash//parola əsasən hash yaradır
            (string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
            }
        }
       
    }
}
