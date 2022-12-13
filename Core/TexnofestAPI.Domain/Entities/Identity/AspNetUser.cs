using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TexnofestAPI.Domain.Entities.Common;

namespace TexnofestAPI.Domain.Entities.Identity
{
    public class AspNetUser : IdentityUser<string>
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public List<Product> Products { get; set; }
        public Guid UserDescription { get; set; }

    }
}
