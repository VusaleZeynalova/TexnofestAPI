using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TexnofestAPI.Domain.Entities;

namespace TexnofestAPI.Application.Features.Queries.Users.GetAllUser
{
    public class GetAllQueryRequest
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public List<ProductUsersRequest> ProductUsers { get; set; }

    }
    public class ProductUsersRequest
    {
        public ProductQueryRequest Product { get; set; }

    }

    public class ProductQueryRequest
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int ProductPoint { get; set; }
    }

}
