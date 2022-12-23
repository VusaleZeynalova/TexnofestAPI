using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TexnofestAPI.Application.Repositories.Products;
using TexnofestAPI.Domain.Entities;

namespace TexnofestAPI.Application.Features.Commands.Products
{
    public class ProductCommandHandler
    {
        private IMapper _mapper;
        private readonly IProductReadRepository _repository;
        public ProductCommandHandler(IMapper mapper,IProductReadRepository productReadRepository)
        {
            _mapper= mapper;
            _repository= productReadRepository;
        }

        public async Task<ProductCommandResponse> GetSingleAsync(string ProductName)
        {
            var result=await _repository.GetByName(ProductName);
            if (result == null)
            {
                return new()
                {
                    Success = false,
                    Message= "This product does not exist"
                };
            }
            return new()
            {
                Success = true,
                Message="Succesfully"

            };
        }
    }
}
