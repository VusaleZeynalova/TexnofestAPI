using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using TexnofestAPI.Application.Repositories.Products;
using TexnofestAPI.Application.Repositories.Users;
using TexnofestAPI.Domain.Entities;

namespace TexnofestAPI.Application.Features.Commands.Users
{
    public class UserCommandHandler
    {
        private readonly IUserReadRepository _readRepository;
        private readonly IUserWriteRepository _writeRepository;
        private readonly IProductReadRepository _productReadRepository;
        public UserCommandHandler(IUserReadRepository readRepository, IUserWriteRepository writeRepository, IProductReadRepository productReadRepository)
        {
            _readRepository = readRepository;
            _writeRepository = writeRepository;
            _productReadRepository = productReadRepository;
        }

        public async Task<UserCommandResponse> GetPython(string userCode, string productName)
        {
            try
            {
                var product = await _productReadRepository.GetByName(productName);
                var user = await _readRepository.GetByGuid(userCode);
                user.ProductUsers = new List<ProductUser>
                {
                    new ProductUser
                    {
                        Product=product,
                        User=user
                    }

                };

                await _writeRepository.SaveAsync();

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

    }
}
