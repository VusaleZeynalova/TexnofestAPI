using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TexnofestAPI.Application.Repositories.Products;
using TexnofestAPI.Application.Repositories.Users;
using TexnofestAPI.Domain.Entities;

namespace TexnofestAPI.Application.Features.Queries.Users.GetAllUser
{
    public class GetAllQueryHandler
    {
        private readonly IUserReadRepository _readRepository;
        private readonly IProductReadRepository _productReadRepository;
        private readonly IMapper _mapper;
        public GetAllQueryHandler(IUserReadRepository readRepository, IMapper mapper,IProductReadRepository productReadRepository)
        {
            _readRepository=readRepository;
            _mapper=mapper; 
            _productReadRepository=productReadRepository;   
        }

        public List<GetAllQueryRequest> GetAll()
        {
            List<User> query = _readRepository.GetAllWitnInclude();
            List<GetAllQueryRequest> getAlls = _mapper.Map<List<GetAllQueryRequest>>(query);
            return getAlls;
        }

    } 
}
